using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Media;
using System.Drawing;
using PdfSharp.Pdf;

namespace pdf2image
{
    public class GS : IDisposable
    {
       public GS()
        {
            if (GS.instance == IntPtr.Zero)
            {
                lock (typeof(GS))
                {
                    if (GS.instance == IntPtr.Zero)
                    {
                        int result = -1000;
                        try
                        {
                            result = Api.gsapi_new_instance(ref GS.instance, IntPtr.Zero);
                        }
                        catch (DllNotFoundException ex)
                        {
                            string message = ex.Message + " Have you forgotten to download gsdll32.dll from http://www.ghostscript.com?";
                            throw new DllNotFoundException(message, ex.InnerException);
                        }
                        if (result != 0)
                            throw new InvalidOperationException("Initialization of Ghostscript DLL failed.");
                    }
                }
            }
        }
        static IntPtr instance;

        public void Dispose()
        {
        }

        public string WorkingDirectory
        {
            get
            {
                if (this.workingDirectory == null || this.workingDirectory.Length == 0)
                    this.workingDirectory = Directory.GetCurrentDirectory();
                return this.workingDirectory;
            }
            set { this.workingDirectory = value; }
        }
        string workingDirectory;

        public Image[] PdfToPng(string filename, int startPage, int endPage, int resolution)
        {
            string outPath = WorkingDirectory;
            string outFile = Guid.NewGuid().ToString("N");
            try
            {
                string[] files = PdfToPngFiles(filename, startPage, endPage, resolution);
                int pageCount = endPage - startPage + 1;
                Image[] images = new Image[pageCount];

                for (int idx = 0; idx < pageCount; idx++)
                {
                    string imageFile = files[idx]; // String.Format("{0}-{1}.png", outFile, idx + 1);
                    images[idx] = Image.FromFile(imageFile);
                }
                return images;
            }
            finally
            {
                DeleteTempFiles(outPath, outFile, endPage - startPage + 1);
            }
        }

        public Image PdfToPng(PdfDocument document, int page, int resolution)
        {
            string tempFile = Guid.NewGuid().ToString("N") + ".pdf";
            try
            {
                document.Save(tempFile);
                return PdfToPng(tempFile, page, resolution);
            }
            finally
            {
                DeleteTempFile(tempFile);
            }
        }

        public Image PdfToPng(string filename, int page, int resolution)
        {
            string outFile = Guid.NewGuid().ToString("N") + ".png";
            FileStream file = null;
            MemoryStream stream = null;
            try
            {
                ArrayList args = new ArrayList();
                args.Add("gs");
                args.Add("-dNOPAUSE");
                args.Add("-dBATCH");
                args.Add("-dSAFER");
                args.Add("-dQUIET");
                args.Add("-sDEVICE=png16m");
                args.Add(String.Format("-r{0}", resolution));
                args.Add("-dTextAlphaBits=2");
                args.Add("-dGraphicsAlphaBits=2");
                args.Add(String.Format("-dFirstPage={0}", page));
                args.Add(String.Format("-sOutputFile={0}", outFile));
                args.Add(String.Format("-f{0}", filename));

                int result = Api.gsapi_init_with_args(GS.instance, args.Count, (string[])args.ToArray(typeof(string)));
                Api.gsapi_exit(GS.instance);
                if (result < 0)
                    throw new InvalidOperationException(String.Format("Ghostscript failed with error code {0}.", result));

                if (File.Exists(outFile))
                {
                    file = new FileStream(outFile, FileMode.Open);
                    int length = (int)file.Length;
                    byte[] bytes = new byte[length];
                    file.Read(bytes, 0, length);
                    file.Close();
                    stream = new MemoryStream(bytes, false);
                    return Image.FromStream(stream);
                }
                return null;
            }
            finally
            {
                if (file != null)
                    file.Close();
                if (stream != null)
                    stream.Close();
                DeleteTempFile(outFile);
            }
        }

        public string[] PdfToPngFiles(string filename, int startPage, int endPage, int resolution)
        {
            string outPath = WorkingDirectory;
            string outFile = Guid.NewGuid().ToString("N");
            try
            {
                ArrayList args = new ArrayList();
                args.Add("gs");
                args.Add("-dNOPAUSE");
                args.Add("-dBATCH");
                args.Add("-dSAFER");
                args.Add("-dQUIET");
                args.Add("-sDEVICE=png16m");
                args.Add(String.Format("-r{0}", resolution));
                args.Add("-dTextAlphaBits=2");
                args.Add("-dGraphicsAlphaBits=2");
                args.Add("-dDEVICEWIDTHPOINTS=700");
                args.Add(String.Format("-dFirstPage={0}", startPage));
                args.Add(String.Format("-dLastPage={0}", endPage));
                args.Add(String.Format("-sOutputFile={0}-%d.png", Path.Combine(outPath, outFile)));
                args.Add(String.Format("-f{0}", filename));

                int result = Api.gsapi_init_with_args(GS.instance, args.Count, (string[])args.ToArray(typeof(string)));
                Api.gsapi_exit(GS.instance);
                if (result < 0)
                    throw new InvalidOperationException(String.Format("Ghostscript failed with error code {0}.", result));

                int pageCount = endPage - startPage + 1;
                string[] files = new String[pageCount];

                for (int idx = 0; idx < pageCount; idx++)
                    files[idx] = String.Format("{0}-{1}.png", outFile, idx + 1);
                return files;
            }
            finally
            {
            }
        }

#if DEBUG_
    /// <summary>
    /// Makes some tests.
    /// </summary>
    public static void MakeSomeTests()
    {
      IntPtr gs = IntPtr.Zero;
      int result = Api.gsapi_new_instance(ref gs, IntPtr.Zero);

      ArrayList args = new ArrayList();
      args.Add("ps2pdf");  /* actual value doesn't matter */
      args.Add("-dNOPAUSE");
      args.Add("-dBATCH");
      args.Add("-dSAFER");
      //args.Add("-sDEVICE=png16m");
      args.Add("-sDEVICE=png16m");
      args.Add("-r300");
      args.Add("-dTextAlphaBits=4");
      args.Add("-dGraphicsAlphaBits=4");
      args.Add("-sOutputFile=empira_briefbogen.png");
      args.Add("-fempira_briefbogen.pdf");
      //args.Add("-c");
      //args.Add(".setpdfwrite");
      //args.Add("-f");
      //args.Add("input.ps");
      result = Api.gsapi_init_with_args(gs, args.Count, (string[])args.ToArray(typeof(string)));
      Api.gsapi_exit(gs);


      args.Clear();
      args.Add("ps2pdf");  /* actual value doesn't matter */
      args.Add("-dNOPAUSE");
      args.Add("-dBATCH");
      args.Add("-dSAFER");
      args.Add("-sDEVICE=bmpgray");
      args.Add("-r600");
      args.Add("-dGraphicsAlphaBits=4");
      args.Add("-sOutputFile=Tiger.bmp");
      args.Add("-ftiger.eps");
      result = Api.gsapi_init_with_args(gs, args.Count, (string[])args.ToArray(typeof(string)));
      Api.gsapi_exit(gs);

      //args.Clear();
      //args.Add("ps2pdf");  /* actual value doesn't matter */
      //args.Add("-dNOPAUSE");
      //args.Add("-dBATCH");
      //args.Add("-dSAFER");
      //args.Add("-sDEVICE=png16m");
      //args.Add("-dGraphicsAlphaBits=4");
      //args.Add("-sOutputFile=Bibel-%000d.png");
      //args.Add("-r300");
      //args.Add("-dFirstPage=10");
      //args.Add("-dLastPage=20");
      //args.Add("Die PostScript- & PDF-Bibel.pdf");
      //result = Api.gsapi_init_with_args(gs, args.Count, args.ToArray(typeof(string)));
      //Api.gsapi_exit(gs);


      Api.gsapi_delete_instance(gs);
    }
#endif

        private void DeleteTempFile(string filename)
        {
            try
            {
                File.Delete(filename);
            }
            catch { }
        }

        private void DeleteTempFiles(string path, string filenamePrefix, int pageCount)
        {
            try
            {
                string[] filenames = Directory.GetFiles(path, filenamePrefix + "*");
                for (int idx = 0; idx < filenames.Length; idx++)
                    try
                    {
                        File.Delete(filenames[idx]);
                    }
                    catch { }
            }
            catch { }
        }

        public static GSRevision Revision
        {
            get
            {
                if (GS.revision == null)
                {
                    Api.gsapi_revision_t revision = new Api.gsapi_revision_t();
                    GS.revision = new GSRevision();
                    try
                    {
                        Api.gsapi_revision(revision, Marshal.SizeOf(revision));

                        GS.revision.Product = revision.product;
                        GS.revision.Copyright = revision.copyright;
                        GS.revision.Revision = revision.revision;
                        GS.revision.RevisionDate = new DateTime(revision.revisiondate / 10000,
                          (revision.revisiondate / 100) % 100, revision.revisiondate % 100);
                    }
                    catch { }
                }
                return GS.revision;
            }
        }
        static GSRevision revision;
    }
}
