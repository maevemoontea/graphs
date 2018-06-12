using System;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;


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
                nodesArray[i] = new Node(this);
                nodesArray[i].Name = dictionary[i];
                double x = Math.Cos(2 * Math.PI * i / this.numberOfNodes) * R + center.X;
                nodesArray[i].position.X = Convert.ToInt32(x);
                double y = Math.Sin(2 * Math.PI * i / this.numberOfNodes) * R + center.Y;
                nodesArray[i].position.Y = Convert.ToInt32(y);
                nodesArray[i].Extent = new int[this.numberOfNodes];
                for (int j = 0; j < this.numberOfNodes; j++)
                {
                    nodesArray[i].Extent[j] = arr[i, j];
                }
            }
            nodes = nodesArray;

            adjacencyMatrix = arr;
            for (int i = 0; i < this.numberOfNodes; i++)
            {
                for (int j = 0; j < this.numberOfNodes; j++)
                {
                    if (adjacencyMatrix[i, j] != 0)
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
                result = nodes[Start].Name + ", " + WriteRoad(Start, Dest, this);
            }
            return result;
        }
        
        private string WriteRoad(int Start, int Dest, Graph graph)
        {
            string way = "and nothing else metter";

            /*string way ="";
            //задання умови виходу і пошуку
            if (graph.nodes[Start].Name == graph.nodes[Dest].Name)
            {
                way = graph.nodes[Start].Name + ", ";
            } else
            {
                if (graph.nodes[Start].Connections.Length > 0 & graph.nodes[Start].Cursor < graph.nodes[Start].Connections.Length)
                {
                    int nextNode = graph.nodes[Start].Cursor;
                    way = this.WriteRoad(nextNode, Dest, this);
                    graph.nodes[Start].Cursor++;
                } else
                {
                    //node has no way out
                }
            }*/

            return way;
        }

        public string BackupsFinding(int distance, int amount, int maxConnections)
        {
            string output = "";
            
            //find available nodes for backups:
            for (int i = 0; i < this.NumberOfNodes; i++)
            {
                output += "Node " + this.Nodes[i].Name + " availables: ";
                this.Nodes[i].Availables = new List<Node>() { };
                this.Nodes[i].StoredNodes = new List<Node>() { };
                this.Nodes[i].BackupArray = new List<Node>() { };
                for (int j = 0; j < this.NumberOfNodes; j++)
                {
                    if (this.adjacencyMatrix[i, j] < distance & this.adjacencyMatrix[i,j] != 0)
                    {
                        this.Nodes[i].Availables.Add(this.Nodes[j]);
                        output += this.Nodes[j].Name + "; ";
                    }
                }
                output += "\r\n";
                if (this.Nodes[i].Availables.Count < amount)
                {
                    output = "Мережа з заданими параметрами неможлива для даного графу. Є вузли, в яких не буде достатньої кількості бекап-пристроїв.";
                    return output;
                }
            }

            //form backups:
            var sortedByAvailability = this.Nodes.OrderBy(node => node.Availables.Count);
            foreach (Node node in sortedByAvailability)
            {
                output += "\r\n Node " + node.Name + " backups: ";
                var stackForBackups = node.Availables.OrderBy(n => n.Degree);
                foreach (Node backup in stackForBackups)
                {
                    /*
                    if (backup.StoredNodes.Count <= maxConnections)
                    {
                        node.BackupArray.Add(backup);
                        backup.StoredNodes.Add(node);
                        output += backup.Name + "; ";
                    }
                    else { break; }
                    */
                    int connections = backup.StoredNodes.Count;
                    if (connections == maxConnections)
                    {
                        continue;
                    }
                    node.BackupArray.Add(backup);
                    backup.StoredNodes.Add(node);
                    output += backup.Name + "; ";
                    if (node.BackupArray.Count == amount)
                    {
                        break;
                    }
                }
                if (node.BackupArray.Count < amount)
                {
                    output = "Мережа з заданими параметрами неможлива для даного графу. Є вузли, в яких не буде достатньої кількості бекап-пристроїв.";
                    return output;
                }
            }

            return output;
        }
    }
}
