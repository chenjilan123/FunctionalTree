using FunctionalTree.VehicleFactory.DataProvider;
using FunctionalTree.VehicleFactory.DbBuilder.Helper;
using Microsoft.SqlServer.Types;
using System;
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
        public TreeNode GetRootNode()
        {
            var rootNode = new TreeNode();
            var parameter = dbHelper.NewParameter();
            parameter.ParameterName = "@orgId";
            parameter.Value = 1;
            using (var reader = dbHelper.GetDataReader("IoT.GetVehicle", new DbParameter[] { parameter }))
            {
                if (!reader.Read())
                    return null;
                var root = vehicleBuilder.ReadNode(reader);
                rootNode.Name = root.Name;

                var lastHierarchyId = root.HierarchyId;
                var lastTreeNode = rootNode;
                while (reader.Read())
                {
                    var node = vehicleBuilder.ReadNode(reader);
                    TreeNode currentTreeNode = null;
                    if (node.SimNum != null)
                        currentTreeNode = vehicleBuilder.CreateNode(node.Name, node.VehicleId, node.SimNum, node.PlateNum, node.TerminalId);
                    else
                        currentTreeNode = new TreeNode(node.Name);
                    if (node.HierarchyId.IsDescendantOf(lastHierarchyId))
                    {
                        lastTreeNode.Nodes.Add(currentTreeNode);
                    }

                    lastHierarchyId = node.HierarchyId;
                    lastTreeNode = currentTreeNode;
                }
            }
            return rootNode;
        }
        
    }
}
