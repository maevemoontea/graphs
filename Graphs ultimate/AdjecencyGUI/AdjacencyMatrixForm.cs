using System;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.IO;

namespace AdjecencyGUI
{
    public partial class AdjacencyMatrixForm : Form
    {
        public AdjacencyMatrixForm(int n)
        {
            InitializeComponent();
            textBoxAdjacencyDescr.Text = "Введіть елементи матриці в текстове поле. Для графу з " + n + " елементів потрібно ввести " + n * n + " значень. В матрицю суміжності можна вводити тільки 0 та 1. Ніякі розділителі не потрібні.";
            textBoxAdjacencyMatrix.MaxLength = n * n;
        }

        private void BtnUseAdjacencyMatrix_Click(object sender, EventArgs e)
        {
            string matrixBody = textBoxAdjacencyMatrix.Text;
            /*StringReader cells = new StringReader(matrixBody);
            //int matrix = cells.Read();

            double dn = Math.Sqrt((double)(matrixBody.Length));
            int n = (int)(dn);
            int[,] matrix = new int[n, n];

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    matrix[i, j] = cells.Read();
                }
            }
            */
            string[] matrix = matrixBody.Select(c => c.ToString()).ToArray();
            string text = "Sorry, it doesn't work now. I'm so sad about this... Elements: ";

            /*foreach ( int i in matrix )
            {
                text += i.ToString() + ", ";
            }
            text += " The lenth is: " + matrix.Length + " and n is:" + n;*/

            textBoxAdjacencyDescr.Text = text;

        }
    }
}
