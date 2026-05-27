using Sowtank.Collections.Graphs;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public NonOrientedGraph<string> graph = new();



    void Start()
    {
        Node<string> a = graph.AddNode("A");
        Node<string> b = graph.AddNode("B");
        Node<string> c = graph.AddNode("C");
        Node<string> d = graph.AddNode("D");

        graph.AddEdges(a,b);
        graph.AddEdges(c, b);
        graph.AddEdges(a, d);

        graph.PrintAdjancencyList();
        graph.PrintAdjacencyMatrix();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
