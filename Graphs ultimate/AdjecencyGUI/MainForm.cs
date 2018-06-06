﻿using System;
using System.Drawing;
using System.Windows.Forms;
using GraphLibrary;

namespace AdjecencyGUI
{
    public partial class MainForm : Form
    {
        Graph greatGraph = new Graph();
        Graphics graphImage;
        Graphics legend;
        Graphics matrixImage;

        public MainForm()
        {
            InitializeComponent();
        }

        private void DrawTheLegend()
        {
            //Graphics legend;
            legend = this.CreateGraphics();
            legend.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Pen edgePen = new Pen(Color.Black, 1);
            Point start = new Point(488, 550);
            Point end = new Point(528, 550);
            legend.DrawLine(edgePen, start, end);

            Size nodeSize = new Size(20, 20);

            Pen nodePen = new Pen(Color.Gray, 3);
            Point node1Start = new Point(498, 562);
            Rectangle legendNode1 = new Rectangle(node1Start, nodeSize);
            legend.DrawEllipse(nodePen, legendNode1);

            Pen isolatedNodePen = new Pen(Color.Red, 3);
            Point node2Start = new Point(636, 562);
            Rectangle legendNode2 = new Rectangle(node2Start, nodeSize);
            legend.DrawEllipse(isolatedNodePen, legendNode2);

            Pen endNodePen = new Pen(Color.BlueViolet, 3);
            Point node3Start = new Point(826, 562);
            Rectangle legendNode3 = new Rectangle(node3Start, nodeSize);
            legend.DrawEllipse(endNodePen, legendNode3);

            //drow areas
            Size matrixAreaSize = new Size(325, 325);
            Point matrixAreaStart = new Point(15, 46);
            Rectangle matrixArea = new Rectangle(matrixAreaStart, matrixAreaSize);
            legend.DrawRectangle(edgePen, matrixArea);

            Size graphAreaSize = new Size(628, 447);
            Point graphAreaStart = new Point(368, 46);
            Rectangle graphArea = new Rectangle(graphAreaStart, graphAreaSize);
            legend.DrawRectangle(edgePen, graphArea);

        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            this.DrawTheLegend();
        }

        private void BtnManualGraph_Click(object sender, EventArgs e)
        {
            int n;
            try
            {
                n = int.Parse(textBoxSetN.Text);
                if (n > 26) { n = 26; }
            }
            catch
            {
                n = 0;
            }
            AdjacencyMatrixForm window = new AdjacencyMatrixForm(n);
            window.Show();
        }

        private void BtnShowDegreesForm_Click(object sender, EventArgs e)
        {
            greatGraph.SetDegrees();
            string text = greatGraph.Degrees;
            DegreesListForm window = new DegreesListForm(text);
            window.Show();
        }

        private void BtnAutoGraph_Click(object sender, EventArgs e)
        {
            int n;
            try
            {
                n = int.Parse(textBoxSetN.Text);
                if (n > 26) { n = 26; }
            }
            catch
            {
                n = 0;
            }
            int[,] matrix = new int[n,n];
            Random r = new Random();
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i,j]=(int)(r.Next(0, 2));
                }
            }

            //only for testing:
            if (n == 5)
            {
                matrix = new int[5, 5] { { 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0 }, { 0, 0, 1, 1, 1 }, { 0, 1, 0, 1, 1 }, { 0, 0, 1, 0, 0 } };
            }
            //end only for testing */

            greatGraph.InitialGraph(n, matrix);

            matrixImage = this.CreateGraphics();
            matrixImage.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            if (n != 0)
            {
                Pen matrixPen = new Pen(Color.LightGray, 1);
                SolidBrush matrixBrush = new SolidBrush(Color.LightGray);
                int x = 275 / n;
                Size cellSize = new Size(x, x);
                int cellX = 40;
                int cellY = 75;

                for (int i = 0; i < n; i++) {
                    for (int j = 0; j < n; j++)
                    {
                        Point cellStart = new Point(cellX, cellY);
                        Rectangle matrixCell = new Rectangle(cellStart, cellSize);
                        matrixImage.DrawRectangle(matrixPen, matrixCell);
                        if (matrix[i, j] == 1)
                        {
                            int checkedX = cellX + 2;
                            int checkedY = cellY + 2;
                            int checkedDiametr = x - 4;
                            Point checkedStart = new Point(checkedX, checkedY);
                            Size checkedSize = new Size(checkedDiametr, checkedDiametr);
                            Rectangle checkedCell = new Rectangle(checkedStart, checkedSize);
                            matrixImage.FillEllipse(matrixBrush, matrixCell);
                        }
                        cellX += x;
                    }
                    cellX = 40;
                    cellY += x;
                }
            }

            graphImage = this.CreateGraphics();
            graphImage.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Size nodeSize = new Size(20, 20);
            Pen nodePen = new Pen(Color.Gray, 3);
            Font drawFont = new Font("Arial", 9);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            foreach (Node verticle in greatGraph.Nodes)
            {
                Rectangle verticlePoint = new Rectangle(verticle.position, nodeSize);
                graphImage.DrawEllipse(nodePen, verticlePoint);

                int x = verticle.position.X + 3;
                int y = verticle.position.Y + 20;
                Point captionPosition = new Point(x, y);
                string caption = verticle.Name + " - " + verticle.Degree.ToString();
                graphImage.DrawString(caption, drawFont, drawBrush, captionPosition);
            }

            this.DrawTheLegend();
        }

        private void BtnViewIsolatedVertices_Click(object sender, EventArgs e)
        {
            graphImage = this.CreateGraphics();
            graphImage.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Size nodeSize = new Size(20, 20);
            Pen nodePen = new Pen(Color.Red, 3);

            foreach (Node verticle in greatGraph.Nodes)
            {
                if (verticle.Degree == 0)
                {
                    Rectangle verticlePoint = new Rectangle(verticle.position, nodeSize);
                    graphImage.DrawEllipse(nodePen, verticlePoint);
                }
            }

            greatGraph.SetIsolatedNodes();
            textBoxNotes.Text += "Ізольованими є вершини: " + greatGraph.IsolatedNodes + "\r\n";

            //btnViewIsolatedVertices.Enabled = false;
        }

        private void BtnViewEndVertices_Click(object sender, EventArgs e)
        {
            graphImage = this.CreateGraphics();
            graphImage.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Size nodeSize = new Size(20, 20);
            Pen nodePen = new Pen(Color.BlueViolet, 3);

            foreach (Node verticle in greatGraph.Nodes)
            {
                if (verticle.Degree == 1)
                {
                    Rectangle verticlePoint = new Rectangle(verticle.position, nodeSize);
                    graphImage.DrawEllipse(nodePen, verticlePoint);
                }
            }

            greatGraph.SetEndNodes();
            textBoxNotes.Text += "Кінцевими є вершини: " + greatGraph.EndNodes + "\r\n";

            //btnViewEndVertices.Enabled = false;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            graphImage.Clear(Color.WhiteSmoke);
            legend.Clear(Color.WhiteSmoke);
            matrixImage.Clear(Color.WhiteSmoke);
            this.DrawTheLegend();
        }

        private void BtnFindTheWay_Click(object sender, EventArgs e)
        {
            FindTheWayForm window = new FindTheWayForm(greatGraph);
            window.Show();
        }

    }
}