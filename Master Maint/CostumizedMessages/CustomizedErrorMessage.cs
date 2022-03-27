using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master_Maint
{
    public partial class CustomizedErrorMessage : Form
    {
        public CustomizedErrorMessage()
        {
            InitializeComponent();
        }

        private void wrongbtn_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes;
            MsgBox.Close();
        }
        static CustomizedErrorMessage MsgBox;
        static DialogResult result = DialogResult.No;
        public static DialogResult Show(string Text, string Caption, string btnOK)
        {
            MsgBox = new CustomizedErrorMessage();
            MsgBox.errorMsg.Text = Text;
            MsgBox.wrongbtn.Text = btnOK;
            MsgBox.Caption.Text = Caption;
            MsgBox.ShowDialog();
            return result;
        }

        private void CustomizedErrorMessage_Load(object sender, EventArgs e)
        {

        }

        private void errorMsg_Click(object sender, EventArgs e)
        {

        }
    }
}
