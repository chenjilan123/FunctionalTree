using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunctionalTree.VehicleFactory.DataProvider.VehicleFactories
{
    public class DbVehicleFactory : IVehicleTreeBuilder
    {
        private DbHelper dbHelper = null;
        public DbHelper DbHelper
        {
            get
            {
                if (dbHelper == null)
                {
                    dbHelper = new DbHelper();
                }

                return dbHelper;
            }
        }
        public TreeNode GetRootNode()
        {
            DataTable dtSource = GetVehicleDataTable();
            foreach (DataRow dr in dtSource.Rows)
            {

            }
            return null;
        }
        
        private DataTable GetVehicleDataTable()
        {
            var parameter = DbHelper.NewParameter();
            parameter.ParameterName = "@orgId";
            parameter.Value = 1;
            return DbHelper.GetDataTable("IoT.GetVehicle", new DbParameter[] { parameter });
        }
    }
}
