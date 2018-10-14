using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalTree.VehicleFactory.DataProvider
{
    public class DbHelper
    {
        private const string ConnectionStringName = "ConnectionString";
        private const string ConnectionStringsSection = "ConnectionStrings";
        private DbProviderFactory factory = null;
        private DbProviderFactory Factory
        {
            get
            {
                //RefreshSection();
                if (factory == null)
                {
                    var provider = ConfigurationManager.ConnectionStrings[ConnectionStringName].ProviderName;
                    factory = DbProviderFactories.GetFactory(provider);
                }
                return factory;
            }
        }
        private DbConnection Connection
        {
            get
            {
                //RefreshSection(); //不调用了，因为只使用SqlServer
                //调用Factory会创建新实例(小型应用程序性能方面可行)
                var connection = Factory.CreateConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings[ConnectionStringName].ConnectionString;
                return connection;
            }
        }
        public DbParameter NewParameter()
        {
            return Factory.CreateParameter();
        }
        /// <summary>
        /// 刷新片段
        /// 动态读取配置
        /// </summary>
        private void RefreshSection()
        {
            ConfigurationManager.RefreshSection(ConnectionStringsSection);
        }

        public DbDataReader GetDataReader(string spName, IEnumerable<DbParameter> parameters)
        {
            var command = GetCommand(spName, parameters);
            command.Connection.Open();
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }
        public DataTable GetDataTable(string spName, IEnumerable<DbParameter> parameters)
        {
            var command = GetCommand(spName, parameters);
            var adapter = Factory.CreateDataAdapter();
            adapter.SelectCommand = command;
            var dataset = new DataSet();
            //当表中含hierarchyid时，可能引发异常，这是因为项目没引用hiererchyid相关的程序集
            adapter.Fill(dataset);
            return dataset.Tables[0];
        }

        private DbCommand GetCommand(string spName, IEnumerable<DbParameter> parameters)
        {
            var command = Factory.CreateCommand();
            command.Connection = Connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = spName;
            foreach (var parameter in parameters)
            {
                command.Parameters.Add(parameter);
            }

            return command;
        }
    }
}
