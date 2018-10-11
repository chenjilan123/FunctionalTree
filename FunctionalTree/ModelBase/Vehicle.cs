using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunctionalTree.ModelBase
{
    public abstract class Vehicle : TreeNode
    {
        public string Manufacturer { get; set; }
    }
}
