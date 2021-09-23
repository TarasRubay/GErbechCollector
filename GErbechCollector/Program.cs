using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GErbechCollector
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = null;
            //Random random = new Random();
            //Console.WriteLine(GC.MaxGeneration);
            //Console.WriteLine(GC.GetGeneration(random));
            //for (int i = 0; i < 100; i++)
            //{
            //    str = new String('*',random.Next(1,10));
            //    // Console.WriteLine(GC.GetGeneration(str));
            //    //GC.Collect();
            //}
            //foreach (var item in str)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(GC.GetGeneration(random));



            //using (UIntArray array = new UIntArray(100))
            //{
            //    for (int i = 0; i < array.Lengs; i++)
            //    {
            //        //array[i] = 0;
            //        Console.Write($"{array[i]} ");
            //    }

            //}


            IntPtr hwnd = ExternalMethods.GetConsoleWindow();
           IntPtr hdc = ExternalMethods.GetDC(hwnd);
            using (Graphics g = Graphics.FromHdc(hdc))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.DrawEllipse(new Pen(Brushes.Blue, 10), 10, 10, 300, 400);
                g.FillEllipse(Brushes.Yellow, 10, 10, 300, 400);
               
            }














                Console.ReadKey();
        }
    }
}
