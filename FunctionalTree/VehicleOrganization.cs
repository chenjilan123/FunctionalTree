using FunctionalTree.DataProvider;
using FunctionalTree.VehicleFactory.Model;
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
            ioTView.BeginUpdate();
            try
            {
                ioTView.Nodes.Clear();
                ioTView.Nodes.Add(new IoTTreeData().GetRootNode());
                ioTView.Nodes[0].Expand();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //一定要调取EndUpdate，不然树会停止绘制
                ioTView.EndUpdate();
            }
        }

        #endregion

        private void refresh_Click(object sender, EventArgs e)
        {
            InitializeTreeNode();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"DBVehicleFactory: {typeof(DataProvider.VehicleFactories.DbVehicleFactory)}" +
            //    $"\r\nXmlVehicleFactory: {typeof(DataProvider.VehicleFactories.XmlVehicleFactory)}" +
            //    $"\r\nVehicleFactory: {typeof(DataProvider.VehicleFactories.VehicleTreeFactory)}");
        }

        private void ioTView_AfterExpand(object sender, TreeViewEventArgs e)
        {
            if (e.Node is Vehicle)
            {
                return;
            }

            e.Node.ImageIndex = 7;
            e.Node.SelectedImageIndex = 7;
        }

        private void ioTView_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            if (e.Node is Vehicle)
            {
                return;
            }

            e.Node.ImageIndex = 6;
            e.Node.SelectedImageIndex = 6;
        }
    }
}
