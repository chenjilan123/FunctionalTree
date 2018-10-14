using FunctionalTree.VehicleFactory.DataProvider;
using FunctionalTree.VehicleFactory.DbBuilder.Helper;
using FunctionalTree.VehicleFactory.Model;
using Microsoft.SqlServer.Types;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunctionalTree.VehicleFactory.DbBuilder
{
    public class DbVehicleTreeBuilder : IVehicleTreeBuilder
    {
        private DbVehicleBuilder vehicleBuilder = new DbVehicleBuilder();
        private DbHelper dbHelper = new DbHelper();
        private Dictionary<SqlHierarchyId, TreeNode> TreeNodeDic = new Dictionary<SqlHierarchyId, TreeNode>();

        public TreeNode GetRootNode()
        {
            TreeNode rootNode = null;
            var parameter = dbHelper.NewParameter();
            parameter.ParameterName = "@orgId";
            parameter.Value = 1;
            using (var reader = dbHelper.GetDataReader("IoT.GetVehicle", new DbParameter[] { parameter }))
            {
                if (!reader.Read())
                    return null;
                var nodePair = GetNewNodePair(reader);
                rootNode = nodePair.Node;

                var lastHierarchyId = nodePair.HierarchyId;
                var lastTreeNode = rootNode;
                while (reader.Read())
                {
                    nodePair = GetNewNodePair(reader);
                    if (nodePair.HierarchyId.IsDescendantOf(lastHierarchyId))
                    {
                        lastTreeNode.Nodes.Add(nodePair.Node);
                    }
                    else
                    {
                        TreeNodeDic[nodePair.HierarchyId.GetAncestor(1)].Nodes.Add(nodePair.Node);
                    }

                    lastHierarchyId = nodePair.HierarchyId;
                    lastTreeNode = nodePair.Node;
                }
            }
            ClearOrgizationWithoutVehicle(rootNode);
            return rootNode;
        }

        private void ClearOrgizationWithoutVehicle(TreeNode node)
        {
            var nodeArr = new ArrayList(node.Nodes);
            foreach (TreeNode childNode in nodeArr)
            {
                if (childNode is Vehicle)
                    continue;
                if (childNode == null || childNode.Nodes == null)
                {
                    continue;
                }
                if (childNode.Nodes.Count == 0)
                    DeleteNodes(childNode);
                else
                    ClearOrgizationWithoutVehicle(childNode);
            }
        }
        private void DeleteNodes(TreeNode node)
        {
            var parentNode = node.Parent;
            parentNode.Nodes.Remove(node);
            if (parentNode.Nodes.Count == 0)
                DeleteNodes(parentNode);
        }

        private (SqlHierarchyId HierarchyId, TreeNode Node) GetNewNodePair(DbDataReader reader)
        {
            var nodePair = vehicleBuilder.CreateNode(reader);
            TreeNodeDic.Add(nodePair.HierarchyId, nodePair.Node);
            return nodePair;
        }
    }
}
