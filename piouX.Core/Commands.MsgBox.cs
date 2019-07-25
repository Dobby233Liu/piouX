using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace piouX.Core
{
    public class Commands
    {
        public class MsgBox
        {
            public static void CmdMsgBox(string text, string caption, MsgBox.Type type)
            {
                MessageBox.Show(text, caption, type.but, type.icn, type.dfBut, type.opt);
            }

            public class Type
            {
                public MessageBoxButtons but;
                public MessageBoxDefaultButton dfBut;
                public MessageBoxIcon icn;
                public MessageBoxOptions opt;
                public Type(
                    MessageBoxButtons buttons,
                    MessageBoxDefaultButton defButton,
                    MessageBoxIcon icon,
                    MessageBoxOptions options
                )
                {
                    but = buttons;
                    dfBut = defButton;
                    icn = icon;
                    opt = options;
                }
            }
        }
    }
}