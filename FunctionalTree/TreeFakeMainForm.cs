using FunctionalTree.DataProvider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunctionalTree
{
    public partial class TreeFakeMainForm : Form
    {
        private IoTTreeData ioTTreeData;

        #region Init
        public TreeFakeMainForm()
        {
            InitializeComponent();
            ioTTreeData = new IoTTreeData();
            InitializeTreeView();
        }

        private void InitializeTreeView()
        {
            try
            {
                ioTView.BeginUpdate();
                var treeNodes = ioTTreeData.GetVehicleTree();
                ioTView.Nodes.Add("Root");
                foreach (var node in treeNodes)
                {
                    ioTView.Nodes[0].Nodes.Add(node.Name);
                }
                ioTView.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion


    }
}
