using System;
using System.Windows.Forms;
using GraphLibrary;

namespace AdjecencyGUI
{
    public partial class FindTheWayForm : Form
    {
        private Graph graphToUse;

        public FindTheWayForm(Graph greatGraph)
        {
            InitializeComponent();

            this.graphToUse = greatGraph;
        }

        private void BtnFindRoad_Click(object sender, EventArgs e)
        {
            //this.graphToUse.SetConnections();
            string startName = textBoxStart.Text;
            string destName = textBoxDestination.Text;
            string RightWay = "RightWay ";

            int startIndex = this.graphToUse.FindNodeIndexByName(startName);
            Node Start = this.graphToUse.Nodes[startIndex];

            int destIndex = this.graphToUse.FindNodeIndexByName(destName);
            Node Dest = this.graphToUse.Nodes[destIndex];

            //запуск алгоритму пошуку
            RightWay = this.graphToUse.FindTheRoad(Start, Dest);

            //обробка результатів (виведення на екран)
            textBoxResult.Text = RightWay;
        }
    }
}
