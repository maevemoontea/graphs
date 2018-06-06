using System.Drawing;

namespace GraphLibrary
{
    public class Node
    {
        private string name;
        public Point position;
        private int degree;
        private string color;
        private string[] connections;
        private string connectionsList;
        private int cursor;

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

        public Node()
        {
            color = "Gray"; //not used yet
            degree = 0;
            connectionsList = "";
            cursor = 0;
        }
    }
}
