using System.Drawing;
using System.Collections.Generic;

namespace GraphLibrary
{
    public class Node
    {
        private Graph parent;
        private string name;
        public Point position;
        private int degree;
        private string color;
        private string[] connections;
        private string connectionsList;
        private int cursor;
        private int[] extent; //міра, об'єм -- мається на увазі вага ребер
        private List<Node> availables;
        private List<Node> backupArray;
        private List<Node> storedNodes;

        public Graph Parent
        {
            get { return parent; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Degree
        {
            get { return degree; }
            set { degree = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string[] Connections
        {
            get { return connections; }
            set { connections = value; }
        }
        public string ConnectionsList
        {
            get { return connectionsList; }
            set { connectionsList = value; }
        }
        public int Cursor
        {
            get { return cursor; }
            set { cursor = value; }
        }
        public int[] Extent
        {
            get { return extent; }
            set { extent = value; }
        }
        public List<Node> Availables
        {
            get { return availables; }
            set { availables = value; }
        }
        public List<Node> BackupArray
        {
            get { return backupArray; }
            set { backupArray = value; } //need to ad an validation: is this value in Extent array?
        }
        public List<Node> StoredNodes
        {
            get { return storedNodes; }
            set { storedNodes = value; }
        }

        public Node(Graph papa)
        {
            parent = papa;
            color = "Gray"; //not used yet
            degree = 0;
            connectionsList = "";
            cursor = 0;
        }
    }
}
