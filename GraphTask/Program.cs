// See https://aka.ms/new-console-template for more information
using GraphTask.Functions;
using GraphTask.Implementation;
using GraphTask.Interfaces;

//------------- seeding sample nodes. ---------------
var node1 = new Node("A");
var node2 = new Node("B");
var node3 = new Node("C");
var node4 = new Node("D");
node1.Children.AddRange(new List<GNode>() { node2, node3 });
node2.Children.AddRange(new List<GNode>() { node4 });
node3.Children.AddRange(new List<GNode>());
//----------------------------------------------------

var gragh = new Graph();
var walks = gragh.WalkGraph(node1);
foreach (var walk in walks)
{
    Console.WriteLine(walk.GetName());

}
var paths = gragh.Paths(node1);
foreach (var path in paths)
{
    Console.WriteLine($"{string.Join("->", path.ConvertAll(s=>s.GetName()))}");
}
