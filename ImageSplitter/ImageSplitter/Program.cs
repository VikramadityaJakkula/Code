using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Media.Imaging;

namespace ImageSplitter
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
                {
                    System.Drawing.Bitmap stitchedImage = new System.Drawing.Bitmap("C:\\Users\\Vikramaditya\\Desktop\\ImageSplitter\\ImageSplitter\\AiBeginner.png");
                    //"C:\\Users\\Vikramaditya\\Desktop\\ImageSplitter\\ImageSplitter\\AiBeginner.png"); args[0]
                string filename = Convert.ToString(args[1]);
                
                char dot = Convert.ToChar(".");
                string[] name = filename.Split(dot);
                int totalheight = Convert.ToInt16(stitchedImage.Height);
                int splitcount;
                int varmode;
                string varVectorScenario;
                String 
                if (totalheight % 1200 != 0)
                    splitcount = totalheight / 1200 + 1;
                else
                    splitcount = totalheight / 1200;

                Console.WriteLine("Software is fun");
     
                
                int temp = 0;
                for(int i =0; i < splitcount; i++)
                {
                    Bitmap b = new Bitmap(stitchedImage.Width, 1200);
                    using (Graphics g = Graphics.FromImage(b))
                    {
                        Rectangle destRect = new Rectangle(0,0,stitchedImage.Width,1200);
                        Rectangle sourceRect = new Rectangle(0,temp , stitchedImage.Width, 1200);
                        g.DrawImage(stitchedImage, destRect, sourceRect, GraphicsUnit.Pixel);
                    }
                    temp = temp + 1200;
                    Console.WriteLine(temp.ToString());
                 b.Save(name[0]+i.ToString()+".png", System.Drawing.Imaging.ImageFormat.Png);
                }   
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oops! Unexpected Error Seen");
                Console.WriteLine("Error should be fixed else more trouble!");
                Console.WriteLine(" ");
                Console.WriteLine(ex.Message.ToString());
                Console.ReadLine();
            }
        }
    }
}
