using System;
using System.Collections.Generic;

public class DirectedGraph
{
    private int V; // Number of vertices
    private List<int>[] adj; // Adjacency list

    // Constructor to initialize the graph with V vertices
    public DirectedGraph(int vertices)
    {
        V = vertices;
        adj = new List<int>[V];
        for (int i = 0; i < V; i++)
        {
            adj[i] = new List<int>();
        }
    }

    // Method to add a directed edge from vertex v to vertex w
    public void AddEdge(int v, int w)
    {
        adj[v].Add(w); // Add w to v's list (v -> w)
    }

    // Method to remove a directed edge from vertex v to vertex w
    public void RemoveEdge(int v, int w)
    {
        adj[v].Remove(w); // Remove w from v's list (v -> w)
    }

    // Method to perform Depth First Search (DFS) traversal
    public void DFS(int startVertex)
    {
        bool[] visited = new bool[V]; // Mark all vertices as not visited
        DFSUtil(startVertex, visited);
    }

    // Recursive utility function for DFS traversal
    private void DFSUtil(int vertex, bool[] visited)
    {
        visited[vertex] = true; // Mark the current vertex as visited
        Console.Write(vertex + " "); // Print the vertex

        // Recur for all vertices adjacent to this vertex
        foreach (int v in adj[vertex])
        {
            if (!visited[v])
            {
                DFSUtil(v, visited);
            }
        }
    }

    // Method to perform Breadth First Search (BFS) traversal
    public void BFS(int startVertex)
    {
        bool[] visited = new bool[V]; // Mark all vertices as not visited

        Queue<int> queue = new Queue<int>();
        visited[startVertex] = true;
        queue.Enqueue(startVertex);

        while (queue.Count != 0)
        {
            int vertex = queue.Dequeue();
            Console.Write(vertex + " ");

            foreach (int v in adj[vertex])
            {
                if (!visited[v])
                {
                    visited[v] = true;
                    queue.Enqueue(v);
                }
            }
        }
    }

    // Method to check if there is a path from vertex start to vertex end
    public bool HasPath(int start, int end)
    {
        bool[] visited = new bool[V]; // Mark all vertices as not visited
        return DFSUtilForPath(start, end, visited);
    }

    // Recursive utility function to check for path from vertex start to vertex end
    private bool DFSUtilForPath(int current, int end, bool[] visited)
    {
        visited[current] = true;

        if (current == end)
        {
            return true;
        }

        foreach (int v in adj[current])
        {
            if (!visited[v])
            {
                if (DFSUtilForPath(v, end, visited))
                {
                    return true;
                }
            }
        }

        return false;
    }
}

public class DirectedGraphDemo
{
    public static void Main()
    {
        // Create a directed graph with 6 vertices
        DirectedGraph graph = new DirectedGraph(6);

        // Add directed edges
        graph.AddEdge(0, 1);
        graph.AddEdge(0, 2);
        graph.AddEdge(1, 2);
        graph.AddEdge(1, 4);
        graph.AddEdge(2, 3);
        graph.AddEdge(3, 4);
        graph.AddEdge(4, 5);

        // Perform DFS traversal starting from vertex 0
        Console.WriteLine("DFS traversal starting from vertex 0:");
        graph.DFS(0);
        Console.WriteLine();

        // Perform BFS traversal starting from vertex 0
        Console.WriteLine("BFS traversal starting from vertex 0:");
        graph.BFS(0);
        Console.WriteLine();

        // Check if there is a path between two vertices (e.g., 0 and 5)
        int start = 0;
        int end = 5;
        bool hasPath = graph.HasPath(start, end);
        Console.WriteLine($"Is there a path between vertex {start} and vertex {end}? {hasPath}");
        Console.WriteLine();

        // Remove an edge (e.g., between vertices 1 and 4)
        graph.RemoveEdge(1, 4);

        // Perform BFS traversal after removing an edge
        Console.WriteLine("BFS traversal after removing edge (1 -> 4):");
        graph.BFS(0);
        Console.WriteLine();
    }
}
