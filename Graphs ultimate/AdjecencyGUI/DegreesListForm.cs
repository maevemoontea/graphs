using System;
using System.Windows.Forms;

namespace AdjecencyGUI
{
    public partial class DegreesListForm : Form
    {
        public DegreesListForm(string text)
        {
            InitializeComponent();
            textBoxDegreesList.Text = text;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
