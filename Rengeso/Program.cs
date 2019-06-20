using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Rengeso
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var clipboardText = ClipBoard;
            if (clipboardText == null) return;

            clipboardText = clipboardText.Replace("\\", "/");

            Clipboard.SetText(clipboardText, TextDataFormat.UnicodeText);
        }

        private static string ClipBoard => Clipboard.ContainsText() ? Clipboard.GetText() : null;
    }
}
