using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace pdf2image
{
    /// <summary>
    /// Interop wrapper of native API. For documentation see http://ghostscript.com/doc/current/API.htm.
    /// </summary>
    internal sealed class Api
    {
        Api() { }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public class gsapi_revision_t
        {
            public string product;
            public string copyright;
            public int revision;
            public int revisiondate;
        }

        [DllImport("gsdll32.dll", CharSet = CharSet.Ansi)]
        public static extern int gsapi_revision([In, Out] gsapi_revision_t revision, int len);

        [DllImport("gsdll32.dll", CharSet = CharSet.Ansi)]
        public static extern int gsapi_new_instance(ref IntPtr pInstance, IntPtr caller_handle);

        [DllImport("gsdll32.dll", CharSet = CharSet.Ansi)]
        public static extern int gsapi_init_with_args(IntPtr pInstance, int argc, [In, Out] string[] argv);

        [DllImport("gsdll32.dll", CharSet = CharSet.Ansi)]
        public static extern int gsapi_exit(IntPtr pInstance);

        [DllImport("gsdll32.dll", CharSet = CharSet.Ansi)]
        public static extern int gsapi_delete_instance(IntPtr pInstance);
    }
}
