using GraphTask.Interfaces;

namespace GraphTask.Implementation
{
    public class Node : GNode
    {
        protected string Name { get; set; }
        public List<GNode> Children { get; set; } = new List<GNode>();
        public Node(string name)
        {
            Name = name;
        }
        public GNode[] GetChildren()
        {
            return Children.ToArray();
        }

        public string GetName()
        {
            return Name;
        }
    }
}
