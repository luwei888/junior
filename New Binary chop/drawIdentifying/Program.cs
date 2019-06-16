using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drawIdentifying
{
    class Program
    {
        static void Main(string[] args)
        {
            Bitmap image = new Bitmap(200, 100);
            Graphics g = Graphics.FromImage(image);

            g.Clear(Color.AliceBlue);
            g.DrawLine(new Pen(Color.Black), new Point(20, 15), new Point(50, 65));
            g.DrawString("hello luwei", new Font("宋体", 14), new SolidBrush(Color.Red), new Point(12, 16));

            image.SetPixel(195, 95, Color.Blue);
            image.Save(@"C:\Users\Administrator\source\repos\draw\image.jpg", ImageFormat.Jpeg);



        }
    }
}
