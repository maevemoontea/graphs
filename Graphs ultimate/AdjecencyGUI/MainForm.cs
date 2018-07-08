using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using GraphLibrary;

namespace AdjecencyGUI
{
    public partial class MainForm : Form
    {
        Graph GraphToUse = new Graph();
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
            legend.SmoothingMode = SmoothingMode.AntiAlias;

            Point start = new Point(488, 550);
            Point end = new Point(628, 550);
            LinearGradientBrush edgeBrush = new LinearGradientBrush(start, end, Color.Black, Color.BlueViolet);
            Pen edgePen = new Pen(edgeBrush, 1);
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
            Pen basicPen = new Pen(Color.Black, 1);

            Size matrixAreaSize = new Size(325, 325);
            Point matrixAreaStart = new Point(15, 46);
            Rectangle matrixArea = new Rectangle(matrixAreaStart, matrixAreaSize);
            legend.DrawRectangle(basicPen, matrixArea);

            Size graphAreaSize = new Size(628, 447);
            Point graphAreaStart = new Point(368, 46);
            Rectangle graphArea = new Rectangle(graphAreaStart, graphAreaSize);
            legend.DrawRectangle(basicPen, graphArea);

        }
        private void ClearTheArea()
        {
            try
            {
                graphImage.Clear(Color.WhiteSmoke);
                legend.Clear(Color.WhiteSmoke);
                matrixImage.Clear(Color.WhiteSmoke);
            }
            catch { }
        }
        private int UseNumberOfNodes()
        {
            int n;
            try
            {
                n = Math.Abs(int.Parse(textBoxSetN.Text));
                if (n > 26)
                {
                    n = 26;
                    string correction = "Максимальна кількість вершин -- 26. По кількості букв англійського алфавіту.";
                    MessageForm message = new MessageForm(correction);
                    message.Show();
                    textBoxSetN.Text = "26";
                }
            }
            catch
            {
                n = 0;
            }
            return n;
        }
        private void DrawTheGraph()
        {
            graphImage = this.CreateGraphics();
            graphImage.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Size nodeSize = new Size(20, 20);
            Pen nodePen = new Pen(Color.Gray, 3);
            Font drawFont = new Font("Arial", 9);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            foreach (Node verticle in GraphToUse.Nodes)
            {
                Rectangle verticlePoint = new Rectangle(verticle.Position, nodeSize);
                graphImage.DrawEllipse(nodePen, verticlePoint);

                int x = verticle.Position.X + 3;
                int y = verticle.Position.Y + 20;
                Point captionPosition = new Point(x, y);
                string caption = verticle.Name + " - " + verticle.Degree.ToString();
                graphImage.DrawString(caption, drawFont, drawBrush, captionPosition);
            }
        }
        private void DrawTheGraphWithEdges()
        {
            graphImage = this.CreateGraphics();
            graphImage.SmoothingMode = SmoothingMode.AntiAlias;
            Size nodeSize = new Size(20, 20);
            Pen nodePen = new Pen(Color.Gray, 3);
            Font drawFont = new Font("Arial", 9);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            Pen edgePen = new Pen(Color.Gray, 1);

            // draw the edges first:
            for (int i = 0; i < GraphToUse.Nodes.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (GraphToUse.AdjacencyMatrix[i, j] != 0)
                    {
                        Point center = new Point(672, 255);
                        int x0 = GraphToUse.Nodes[i].Position.X + 10;
                        int y0 = GraphToUse.Nodes[i].Position.Y + 10;
                        int x3 = GraphToUse.Nodes[j].Position.X + 10;
                        int y3 = GraphToUse.Nodes[j].Position.Y + 10;
                        Point P0 = new Point(x0, y0);
                        Point P3 = new Point(x3, y3);
                        int x1 = P0.X - (P0.X - center.X) / 2;
                        int y1 = P0.Y - (P0.Y - center.Y) / 2;
                        int x2 = P3.X - (P3.X - center.X) / 2;
                        int y2 = P3.Y - (P3.Y - center.Y) / 2;
                        Point P1 = new Point(x1, y1);
                        Point P2 = new Point(x2, y2);
                        Point gradientStart = new Point(x0, y0);
                        Point gradientEnd = new Point(x3, y3);
                        LinearGradientBrush edgeBrush = new LinearGradientBrush(gradientStart, gradientEnd, Color.Black, Color.BlueViolet);
                        edgePen = new Pen(edgeBrush);
                        graphImage.DrawBezier(edgePen, P0, P1, P2, P3);
                    }
                }
                if (GraphToUse.AdjacencyMatrix[i, i] != 0)
                {
                    Point center = new Point(672, 255);
                    int diametr = 60;
                    int x = 0;
                    int y = 0;
                    if (GraphToUse.Nodes[i].Position.X < center.X)
                    {
                        if (GraphToUse.Nodes[i].Position.Y < center.Y)
                        {
                            x = GraphToUse.Nodes[i].Position.X - diametr + 20;
                            y = GraphToUse.Nodes[i].Position.Y - diametr + 20;
                        }
                        else
                        {
                            x = GraphToUse.Nodes[i].Position.X - diametr + 20;
                            y = GraphToUse.Nodes[i].Position.Y;
                        }
                    }
                    else
                    {
                        if (GraphToUse.Nodes[i].Position.Y < center.Y)
                        {
                            x = GraphToUse.Nodes[i].Position.X;
                            y = GraphToUse.Nodes[i].Position.Y - diametr + 20;
                        }
                        else
                        {
                            x = GraphToUse.Nodes[i].Position.X;
                            y = GraphToUse.Nodes[i].Position.Y;
                        }
                    }
                    graphImage.DrawEllipse(edgePen, x, y, diametr, diametr);
                }
                for (int j = i + 1; j < GraphToUse.Nodes.Length; j++)
                {
                    if (GraphToUse.AdjacencyMatrix[i, j] != 0)
                    {
                        Point center = new Point(672, 255);
                        int x0 = GraphToUse.Nodes[i].Position.X + 10;
                        int y0 = GraphToUse.Nodes[i].Position.Y + 10;
                        int x3 = GraphToUse.Nodes[j].Position.X + 10;
                        int y3 = GraphToUse.Nodes[j].Position.Y + 10;
                        Point P0 = new Point(x0, y0);
                        Point P3 = new Point(x3, y3);
                        int x1 = P0.X + (P0.X - center.X) / 2;
                        int y1 = P0.Y + (P0.Y - center.Y) / 2;
                        int x2 = P3.X + (P3.X - center.X) / 2;
                        int y2 = P3.Y + (P3.Y - center.Y) / 2;
                        Point P1 = new Point(x1, y1);
                        Point P2 = new Point(x2, y2);
                        Point gradientStart = new Point(x0, y0);
                        Point gradientEnd = new Point(x3, y3);
                        LinearGradientBrush edgeBrush = new LinearGradientBrush(gradientStart, gradientEnd, Color.Black, Color.BlueViolet);
                        edgePen = new Pen(edgeBrush);
                        graphImage.DrawBezier(edgePen, P0, P1, P2, P3);
                    }
                }
            }

            // finally draw the verticles:
            foreach (Node verticle in GraphToUse.Nodes)
            {
                Rectangle verticlePoint = new Rectangle(verticle.Position, nodeSize);
                graphImage.FillEllipse(drawBrush, verticlePoint);
                graphImage.DrawEllipse(nodePen, verticlePoint);

                int x = verticle.Position.X + 3;
                int y = verticle.Position.Y + 20;
                Point captionPosition = new Point(x, y);
                string caption = verticle.Name + " - " + verticle.Degree.ToString();
                graphImage.DrawString(caption, drawFont, drawBrush, captionPosition);
            }
        }

        private void ToolStripBtnAutoGraph_Click(object sender, EventArgs e)
        {
            this.ClearTheArea();
            this.DrawTheLegend();
            int n;
            n = this.UseNumberOfNodes();
            int[,] matrix = new int[n, n];
            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = (int)(r.Next(0, 2));
                }
            }

            GraphToUse.InitialGraph(n, matrix);

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

                for (int i = 0; i < n; i++)
                {
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

            this.DrawTheGraphWithEdges();
        }

        private void ToolStripAutoGraphSymm_Click(object sender, EventArgs e)
        {
            this.ClearTheArea();
            this.DrawTheLegend();
            int n;
            n = this.UseNumberOfNodes();
            int[,] matrix = new int[n, n];
            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    matrix[i, j] = (int)(r.Next(0, 9));
                    matrix[j, i] = matrix[i, j];
                }
                matrix[i, i] = 0;
            }

            GraphToUse.InitialGraph(n, matrix);

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
                int fontSize = x * 3 / 5;
                int fontPosition = x * 1 / 8;
                //if (n > 17) { fontSize = 6; fontPosition = 0; }

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Point cellStart = new Point(cellX, cellY);
                        Rectangle matrixCell = new Rectangle(cellStart, cellSize);
                        matrixImage.DrawRectangle(matrixPen, matrixCell);
                        if (matrix[i, j] != 0)
                        {
                            int checkedX = cellX + fontPosition;
                            int checkedY = cellY + fontPosition;
                            int checkedDiametr = x - 2 * fontPosition;
                            Point checkedStart = new Point(checkedX, checkedY);
                            Size checkedSize = new Size(checkedDiametr, checkedDiametr);
                            Rectangle checkedCell = new Rectangle(checkedStart, checkedSize);
                            Font matrixFont = new Font("Arial", fontSize);
                            SolidBrush matrix2Brush = new SolidBrush(Color.Black);
                            string veight = matrix[i, j].ToString();
                            matrixImage.DrawString(veight, matrixFont, matrix2Brush, checkedCell);
                        }
                        cellX += x;
                    }
                    cellX = 40;
                    cellY += x;
                }
            }

            this.DrawTheGraphWithEdges();
        }

        private void ToolStripClear_Click(object sender, EventArgs e)
        {
            this.ClearTheArea();
            this.DrawTheLegend();
            textBoxNotes.Text = "";
            textBoxSetN.Text = "";
        }

        private void ToolStripManualGraph_Click(object sender, EventArgs e)
        {
            this.ClearTheArea();
            this.DrawTheLegend();
            int n;
            n = this.UseNumberOfNodes();
            AdjacencyMatrixForm window = new AdjacencyMatrixForm(n);
            window.Show();
        }

        private void ToolStripShowDegreesForm_Click(object sender, EventArgs e)
        {
            GraphToUse.SetDegrees();
            string text = GraphToUse.Degrees;
            textBoxNotes.Text += "Ступені вершин графу: " + text + "\r\n";
        }

        private void ToolStripViewIsolatedVertices_Click(object sender, EventArgs e)
        {
            graphImage = this.CreateGraphics();
            graphImage.SmoothingMode = SmoothingMode.AntiAlias;
            Size nodeSize = new Size(20, 20);
            Pen nodePen = new Pen(Color.Red, 3);

            foreach (Node verticle in GraphToUse.Nodes)
            {
                if (verticle.Degree == 0)
                {
                    Rectangle verticlePoint = new Rectangle(verticle.Position, nodeSize);
                    graphImage.DrawEllipse(nodePen, verticlePoint);
                }
            }

            GraphToUse.SetIsolatedNodes();
            textBoxNotes.Text += "Ізольованими є вершини: " + GraphToUse.IsolatedNodes + "\r\n";

            //btnViewIsolatedVertices.Enabled = false;
        }

        private void ToolStripViewEndVertices_Click(object sender, EventArgs e)
        {
            graphImage = this.CreateGraphics();
            graphImage.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Size nodeSize = new Size(20, 20);
            Pen nodePen = new Pen(Color.BlueViolet, 3);

            foreach (Node verticle in GraphToUse.Nodes)
            {
                if (verticle.Degree == 1)
                {
                    Rectangle verticlePoint = new Rectangle(verticle.Position, nodeSize);
                    graphImage.DrawEllipse(nodePen, verticlePoint);
                }
            }

            GraphToUse.SetEndNodes();
            textBoxNotes.Text += "Кінцевими є вершини: " + GraphToUse.EndNodes + "\r\n";

            //btnViewEndVertices.Enabled = false;
        }

        private void ToolStripFindTheWay_Click(object sender, EventArgs e)
        {
            FindTheWayForm window = new FindTheWayForm(GraphToUse);
            window.Show();
        }

        private void ToolStripBackupWindow_Click(object sender, EventArgs e)
        {
            FindBackupsForm window = new FindBackupsForm(GraphToUse, this);
            window.Show();
        }
    }
}
