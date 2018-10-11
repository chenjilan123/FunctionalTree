using FunctionalTree.DataProvider;
using System;
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
                ioTView.Nodes.Add(new IoTTreeData().GetRootNode());
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
