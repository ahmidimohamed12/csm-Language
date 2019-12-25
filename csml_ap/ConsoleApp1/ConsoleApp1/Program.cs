using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing;

namespace ConsoleApp1
{
    class Program
    {
        public static string cmd;
        static void affconsol()
        {
            //Console.WriteLine("=================== CSML =========================\n");
            //Console.WriteLine("\n\n\n");
            //for (int i = 0; i < 100000000; i++)
            //{
            //    Console.Write("CSML==>\t");
            //    cmd = Console.ReadLine();
            //    if (cmd == "Exit")
            //        break;
            //    if (cmd == "Clear")
            //    {
            //        Console.Clear();
            //        Console.WriteLine("=================== CSML =========================\n");
            //    }

            ////}
            //if ("")
            //Console.WriteLine();
        }
       public  static void afl(string s)
        {
            if (s == "console()")
                Console.WriteLine("Hello");

        }
        static void Main(string[] args)
        {
           // affconsol();
            Form fr = new Form();
            fr.Width = 1000;
            fr.Height = 1500;
            fr.BackColor = Color.White;
            
            // Button Compiler
            Button btn = new Button();
            btn.Location = new Point(200, 20);
            btn.Text = "hy";
          
            fr.Controls.Add(btn);
            //
           
            //
            RichTextBox ls = new RichTextBox();
            ls.Location = new Point(100, 50);
            ls.Width = 500;
            ls.Height = 1700;

            btn.Click += (s, e) => {
                    Console.WriteLine("Hy");
                
                //afl(ls.Text);
            };
            fr.Controls.Add(ls);
            Application.Run(fr);

            
        }
    }
}
