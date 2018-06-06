using System;
using System.Drawing;
using System.Linq;


namespace GraphLibrary
{
    public class Graph
    {
        private int numberOfNodes;
        private Node[] nodes;
        private int[,] adjacencyMatrix;
        private string[] dictionary;
        private string isolatedNodes;
        private string endNodes;
        private string degrees;

        public int NumberOfNodes
        {
            get { return numberOfNodes; }
        }
        public Node[] Nodes
        {
            get { return nodes; }
        }

        public void InitialGraph(int numberOfNodes, int[,] arr)  
        {
            dictionary = new string[26] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            this.numberOfNodes = numberOfNodes;
            if (this.numberOfNodes > 26) { this.numberOfNodes = 26; }

            //circle:
            Point center = new Point(672, 255);
            int R = 70 + 5 * this.numberOfNodes;

            Node[] nodesArray = new Node[this.numberOfNodes];
            for (int i = 0; i < this.numberOfNodes; i ++)
            {
                nodesArray[i] = new Node();
                nodesArray[i].Name = dictionary[i];
                double x = Math.Cos(2 * Math.PI * i / this.numberOfNodes) * R + center.X;
                nodesArray[i].position.X = Convert.ToInt32(x);
                double y = Math.Sin(2 * Math.PI * i / this.numberOfNodes) * R + center.Y;
                nodesArray[i].position.Y = Convert.ToInt32(y);
            }
            nodes = nodesArray;

            adjacencyMatrix = arr;
            for (int i = 0; i < this.numberOfNodes; i++)
            {
                for (int j = 0; j < this.numberOfNodes; j++)
                {
                    if (adjacencyMatrix[i, j] == 1)
                    {
                        nodes[i].Degree += 1;
                        nodes[i].ConnectionsList += j;
                    }
                }
            }

            for (int i = 0; i < this.NumberOfNodes; i++)
            {
                string[] array = nodes[i].ConnectionsList.Select(c => c.ToString()).ToArray();
                nodes[i].Connections = array;//Array.ConvertAll(array, element => Convert.ToInt32(element));
            }

        }

        public string IsolatedNodes
        {
            get { return isolatedNodes; }
        }
        public void SetIsolatedNodes()
        {
            isolatedNodes = "";
            foreach (Node verticle in nodes)
            {
                if (verticle.Degree == 0)
                {
                    isolatedNodes += verticle.Name + ", ";
                }
            }
            if (isolatedNodes == "")
            {
                isolatedNodes = " граф не містить ізольованих вершин. \r\n";
            }
        }

        public string EndNodes
        {
            get { return endNodes; }
        }
        public void SetEndNodes()
        {
            endNodes = "";
            foreach (Node verticle in nodes)
            {
                if (verticle.Degree == 1)
                {
                    endNodes += verticle.Name + ", ";
                }
            }
            if (endNodes == "")
            {
                endNodes = " граф не містить кінцевих вершин. \r\n";
            }
        }

        public string Degrees
        {
            get { return degrees; }
        }
        public void SetDegrees()
        {
            degrees = "";
            foreach (Node verticle in nodes)
            {
                degrees += verticle.Degree + ", ";
            }
            if (degrees == "")
            {
                degrees = "Ступені вершин графа не задані.";
            }
        }

        public string FindTheRoad(int Start, int Dest)
        {
            string result = "Поки що нічого не знайдено";

            //перевірка, чи не збігаються ноди, бо тоді не варто й запускати алгоритм
            if (nodes[Start].Name == nodes[Dest].Name)
            {
                result = "Вказані вершини збігаються";
            }
            //перевірка, чи не є вибрані ноди ізольованими, бо тоді не варто й запускати алгоритм
            else if (nodes[Start].Degree == 0 | nodes[Dest].Degree == 0)
            {
                result = "Вказані вершини не з'єднані.";
            }
            else
            {
                //запуск рекурсії
                result = nodes[Start].Name + ", " + WriteRoad(Start, Dest);
            }
            return result;
        }
        
        public string WriteRoad(int Start, int Dest)
        {
            string way ="";
            //задання умови виходу і пошуку
            if (nodes[Start].Name == nodes[Dest].Name)
            {
                way = nodes[Start].Name + ", ";
            } else
            {
                if (nodes[Start].Connections.Length > 0 & nodes[Start].Cursor < nodes[Start].Connections.Length)
                {
                    int nextNode = nodes[Start].Cursor;
                    way = this.WriteRoad(nextNode, Dest);
                    nodes[Start].Cursor++;
                } else
                {
                    //node has no way out
                }
            }

            return way;
        }
    }
}
