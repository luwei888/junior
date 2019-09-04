using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventExample2
{
   internal class Myform3:Form
    {
        private TextBox textBox;
        private Button button;
        public Myform3()
        {
            this.textBox = new TextBox();
            this.button = new Button();
            this.Controls.Add(button);
            this.Controls.Add(textBox);
            this.button.Text = "按钮";
            this.button.Top = 30;
            this.button.Click += this.Buttonclick;
        }

        private void Buttonclick(object sender, EventArgs e)
        {
            this.textBox.Text = "hello world!";
        }
    }
}
