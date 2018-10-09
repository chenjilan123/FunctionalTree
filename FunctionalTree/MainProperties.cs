using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunctionalTree
{
    class MainProperties
    {
        public void Tree()
        {
            //https://docs.microsoft.com/zh-cn/dotnet/framework/winforms/controls/treeview-control-windows-forms
            var tree = new TreeView();
            //Nodes: Contains the list of top-level nodes in the tree view.
            TreeNodeCollection topNodes = tree.Nodes;
            //SelectedNode: sets the currently selected node. 
            TreeNode node = tree.SelectedNode;
            //The state images displayed in the TreeView are 16 x 16 pixels by default
            //ImageList: icons can display next to node.
            ImageList imgs = tree.ImageList;
            //ImageIndex: sets the default image for nodes in the tree view.
            int imgIndex = tree.ImageIndex;

            //Checkbox--'+' '-'--Lines can all be hide.
            tree.CheckBoxes = false;
            tree.ShowPlusMinus = false;
            tree.ShowLines = false;
            tree.ShowRootLines = false;
            tree.Scrollable = false;
            //HotTracking: changes the appearance of the tree node labels as the mouse pointer passes over them.
            tree.HotTracking = false;
            //completely customize the appearance of the TreeView control. 
            //set the DrawMode property to a value other than TreeViewDrawMode.Normal 
            //and handle the DrawNode event.
            tree.DrawMode = TreeViewDrawMode.OwnerDrawAll;
            tree.DrawMode = TreeViewDrawMode.OwnerDrawText;
            tree.DrawNode += (o, e) => 
            {
                var graphic = e.Graphics;
                //https://docs.microsoft.com/zh-cn/dotnet/api/system.windows.forms.treeview.drawnode?view=netframework-4.7.2
            };
        }
        public void Node()
        {
            //https://docs.microsoft.com/zh-cn/dotnet/api/system.windows.forms.treenode?view=netframework-4.7.2
            //Five overload.
            //public TreeNode();
            //public TreeNode(string text);
            //public TreeNode(string text, TreeNode[] children);
            //public TreeNode(string text, int imageIndex, int selectedImageIndex);
            //public TreeNode(string text, int imageIndex, int selectedImageIndex, TreeNode[] children);
            var node = new TreeNode();
            //FullPath: determine where a TreeNode label begins and ends.
            //          work together with PathSeparator.
            string path = node.FullPath;

            //override the default images.
            int imgIndex = node.ImageIndex;
            int selectedImgIndex = node.SelectedImageIndex;
            //Toggole: alternate between the expanded and collapsed states.
            node.Toggle();
        }

        public void Check()
        {
            //To prevent the check event from being raised multiple times, 
            //add logic to your event handler that only executes your recursive 
            //code if the Action property of the TreeViewEventArgs is not set to TreeViewAction.Unknown. 
            var eventArg = new TreeViewEventArgs(null);
            var action = eventArg.Action;
            var tree = new TreeView();
            tree.AfterCheck += (o, e) => 
                {
                    //https://docs.microsoft.com/zh-cn/dotnet/api/system.windows.forms.treeview.aftercheck?view=netframework-4.7.2 
                };
            tree.BeforeCheck += (o, e) => 
                {
                    //https://docs.microsoft.com/zh-cn/dotnet/api/system.windows.forms.treeview.beforecheck?view=netframework-4.7.2
                };
                                              //TreeViewAction enum.
                                              //Unknown = 0,
                                              //ByKeyboard = 1,
                                              //ByMouse = 2,
                                              //Collapse = 3,
                                              //Expand = 4
                }
    }
}
