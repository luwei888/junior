using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Form form = new Form();
            //Controller controller = new Controller(form);
            //form.ShowDialog();

            //Myform myform = new Myform();
            //myform.Click += myform.Action;
            //myform.ShowDialog();

            Myform3 myform3 = new Myform3();
            myform3.ShowDialog();
        }
    }

    class Controller
    {
        private Form form;
        public Controller(Form form)
        {
            if (form!=null)
            {
                this.form = form;
                this.form.Click += Action;
            }
        }

        private void Action(object sender, EventArgs e)
        {
            this.form.Text = DateTime.Now.ToString();
        }
    }
}
