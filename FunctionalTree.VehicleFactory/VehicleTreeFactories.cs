using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalTree.VehicleFactory
{
    public static class VehicleTreeFactories
    {
        private static string VehicleTreeFactoryType
        {
            get
            {
                ConfigurationManager.RefreshSection("appSettings"); //可运行时动态更改配置//注意xml区分大小写
                return ConfigurationManager.AppSettings["DataFactory"].ToString();
            }
        }

        public static AbstractDataFactory CreateFactory()
        {
            Type type = Type.GetType(VehicleTreeFactoryType);
            return type.Assembly.CreateInstance(type.FullName) as AbstractDataFactory;
        }
    }
}
