using piouX.Core;
using System;
using System.Windows.Forms;

namespace piouX.GUI
{
    public partial class GUIMain : Form
    {
        public GUIMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Commands.MsgBox.Type type = new Commands.MsgBox.Type(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1, MessageBoxIcon.Information, 0);
            Commands.MsgBox.CmdMsgBox("Hello world!", Text, type);
        }
    }
}
