using System;
using System.Drawing;
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
            string startName = textBoxStart.Text;
            string destName = textBoxDestination.Text;
            string RightWay = "RightWay ";
            // для пошуку індексу of the node за назвою використаю той самий масив, який використовуваля для іменування нодів, хоча треба це робити безпосередньо на графі або просити у користувача індекси. Я б створила на зображенні графу контроли для вибору нодів, які б одразу містили індекси.
            string[] dictionary = new string[26] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            int startIndex = 0;

            int destIndex = 0;
            for (int i = 0; i < dictionary.Length; i++)
            {
                if (dictionary[i] == startName)
                {
                    startIndex = i;
                }
                if (dictionary[i] == destName)
                {
                    destIndex = i;
                }
            }

            //запуск алгоритму пошуку
            RightWay = this.graphToUse.FindTheRoad(startIndex, destIndex);

            //обробка результатів (виведення на екран)
            textBoxResult.Text = RightWay;
        }
    }
}
