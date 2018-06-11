using System;
using System.Windows.Forms;
using GraphLibrary;

namespace AdjecencyGUI
{
    public partial class FindBackupsForm : Form
    {
        private Graph graphToUse;

        public FindBackupsForm(Graph graphG, Form motherForm)
        {
            InitializeComponent();
            this.graphToUse = graphG;
        }

        private void BtnFindBackups_Click(object sender, EventArgs e)
        {
            string correction = "Для розрахунків потрібно ввести дійсні числа в поля: \r\n";
            MessageForm message = new MessageForm(correction);
            int distance;
            int amount;
            int maxConnections;

            try
            {
                distance = Math.Abs(int.Parse(textBoxDistance.Text));
            }
            catch
            {
                distance = 0;
                correction += "Дистанція взаємодії \r\n";
                message.SetMessage(correction);
                message.Show();
            }
            try
            {
                amount = Math.Abs(int.Parse(textBoxAmount.Text));

            }
            catch
            {
                amount = 0;
                correction += "Кількість бекап-пристроїв \r\n";
                message.SetMessage(correction);
                message.Show();
            }
            try
            {
                maxConnections = Math.Abs(int.Parse(textBoxMaxConnections.Text));
            }
            catch
            {
                maxConnections = 0;
                correction += "Максимальне навантаження на пристрій \r\n";
                message.SetMessage(correction);
                message.Show();
            }

            textBoxConfiguration.Text = graphToUse.BackupsFinding(distance, amount, maxConnections);

        }
    }
}
