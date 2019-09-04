using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventExample2
{
    internal class Myform : Form
    {
        internal void Action(object sender, EventArgs e)
        {
            Text = DateTime.Now.ToString();
        }
    }
}
