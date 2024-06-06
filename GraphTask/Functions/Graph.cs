using GraphTask.Interfaces;

namespace GraphTask.Functions
{
    public class Graph
    {
        public List<GNode> WalkGraph(GNode node)
        {
            //DFS implementation to walk thorough all each node
            var passedByNodes = new List<GNode>();
            var visited = new HashSet<GNode>();
            WalkGrapgh(passedByNodes, visited, node);
            return passedByNodes;

        }
        private void WalkGrapgh(List<GNode> passedByNodes, HashSet<GNode> visited, GNode node)
        {
            if (node == null || visited.Contains(node))
                return;
            visited.Add(node);
            passedByNodes.Add(node);
            foreach (var child in node.GetChildren())
            {
                WalkGrapgh(passedByNodes, visited, child);
            }

        }

        // backtracking and DFS to all get all desired paths
        public List<List<GNode>> Paths(GNode node)
        {
            var allPaths = new List<List<GNode>>();
            var currPath = new List<GNode>();
            Paths(allPaths, currPath, node);
            return allPaths;
        }

        private void Paths(List<List<GNode>> allPaths, List<GNode> current, GNode node)
        {
            if (node == null)
                return;

            current.Add(node);

            if (node.GetChildren().Length == 0)
            {
                allPaths.Add(new List<GNode>(current));
            }
            else
            {
                foreach (var child in node.GetChildren())
                {
                    Paths(allPaths, current, child);
                }

            }
            //backtracking: removing last added path.
            current.Remove(node);
        }
    }
}
