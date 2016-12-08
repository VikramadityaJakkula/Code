using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using PdfSharp;

namespace pdf2image
{
    class Program
    {
        public static System.Drawing.Bitmap Combine(string[] files)
        {
            //read all images into memory
            List<System.Drawing.Bitmap> images = new List<System.Drawing.Bitmap>();
            System.Drawing.Bitmap finalImage = null;

            try
            {
                int width = 0;
                int height = 0;

                foreach (string image in files)
                {
                    //create a Bitmap from the file and add it to the list
                    System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(image);

                    //update the size of the final bitmap
                    height += bitmap.Height;
                    width = bitmap.Width > width ? bitmap.Width : width;

                    images.Add(bitmap);
                }

                //create a bitmap to hold the combined image
                finalImage = new System.Drawing.Bitmap(width, height);

                //get a graphics object from the image so we can draw on it
                using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(finalImage))
                {
                    //set background color
                    g.Clear(System.Drawing.Color.Black);

                    //go through each image and draw it on the final image
                    int offset = 0;
                    foreach (System.Drawing.Bitmap image in images)
                    {
                        g.DrawImage(image, new System.Drawing.Rectangle(0, offset, image.Width, image.Height));
                        offset += image.Height;
                    }
                }

                return finalImage;
            }
            catch (Exception ex)
            {
                if (finalImage != null)
                    finalImage.Dispose();

                throw ex;
            }
            finally
            {
                //clean up memory
                foreach (System.Drawing.Bitmap image in images)
                {
                    image.Dispose();
                }
            }
        }
        

        static void Main(string[] args)
        {

            try
            {

                string filename = args[0];

                // Create instance of Ghostscript wrapper class.
                GS gs = new GS();
                int first = Convert.ToInt16(args[1]);
                int last = Convert.ToInt16(args[2]);
                int dpi = Convert.ToInt16(args[3]);

                string[] files = gs.PdfToPngFiles(filename, first, last, dpi);
                System.Drawing.Bitmap stitchedImage = Combine(files);

                stitchedImage.Save(args[4], System.Drawing.Imaging.ImageFormat.Png);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oops! Unexpected Error Seen");
            }
        }
    }
}
