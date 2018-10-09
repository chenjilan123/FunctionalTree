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
            
        }
        public void Node()
        {
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
    }
}
