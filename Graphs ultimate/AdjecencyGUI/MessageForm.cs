using System;
using System.Windows.Forms;

namespace AdjecencyGUI
{
    public partial class MessageForm : Form
    {
        public MessageForm(string message)
        {
            InitializeComponent();
            textBoxMessage.Text = message;
        }

        public void SetMessage(string newMessage)
        {
            textBoxMessage.Text = newMessage;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
