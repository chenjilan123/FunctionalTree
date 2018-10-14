using FunctionalTree.VehicleFactory.Model;
using Microsoft.SqlServer.Types;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunctionalTree.VehicleFactory.DbBuilder.Helper
{
    public class DbVehicleBuilder
    {
        public (SqlHierarchyId HierarchyId, TreeNode Node) CreateNode(DbDataReader reader)
        {
            var node = reader.GetFieldValue<SqlHierarchyId>(0);
            var name = reader["Name"].ToString();
            var vehicleId = reader["VehicleId"].ToString();
            if (string.IsNullOrEmpty(vehicleId))
            {
                return (node, new TreeNode(name));
            }
            var simnum = reader["SimNum"].ToString();
            var platenum = reader["PlateNum"].ToString();
            var terminalId = reader["TerminalId"].ToString();
            return (node, CreateNode(name, vehicleId, simnum, platenum, terminalId));
        }

        public TreeNode CreateNode(string name, string vehicleId, string simnum, string platenum, string terminalId)
        {
            var node = new Ferrari();
            node.Text = node.Name = name;
            return node;
        }
    }
}
