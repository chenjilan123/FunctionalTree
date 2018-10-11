using FunctionalTree.DataProvider;
using System;
using System.Windows.Forms;

namespace FunctionalTree
{
    public partial class VehicleOrganization : Form
    {
        private IoTTreeData ioTTreeData;

        #region Init
        public VehicleOrganization()
        {
            InitializeComponent();
            ioTTreeData = new IoTTreeData();
            InitializeTreeView();
            InitializeTreeNode();

        }

        private void InitializeTreeView()
        {
            ioTView.NodeMouseHover += IoTView_NodeMouseHover;
        }

        private void IoTView_NodeMouseHover(object sender, TreeNodeMouseHoverEventArgs e)
        {
            //var currentNode = e.Node;
            //Cursor = Cursors.Hand;
        }

        private void InitializeTreeNode()
        {
            try
            {
                ioTView.BeginUpdate();
                ioTView.Nodes.Clear();
                ioTView.Nodes.Add(new IoTTreeData().GetRootNode());
                ioTView.Nodes[0].Expand();
                ioTView.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        #endregion

        private void refresh_Click(object sender, EventArgs e)
        {
            InitializeTreeNode();
        }

        private void ioTView_MouseMove(object sender, MouseEventArgs e)
        {
            //可以出现手型指针，但会抖动。
            //var node = ioTView.GetNodeAt(e.X, e.Y);
            //Cursor = node == null ? Cursors.Default : Cursors.Hand;
        }
    }
}
