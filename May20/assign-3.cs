// Graph Algorithm -- Sortest Path (Dijkstra's Algorithm)
using System;
using System.Collections.Generic;

class DijkstraAlgorithm
{
    static int MiniDistance(int[] dist, bool[] visited, int vertices)
    {
        int min = int.MaxValue, minIndex = -1;
        for (int v = 0; v < vertices; v++)
        {
            if (!visited[v] && dist[v] <= min)
            {
                min = dist[v];
                minIndex = v;
            }
        }
        return minIndex;
    }
    static void Dijkstra(int[,] graph, int src, int vertices)
    {
        int[] dist = new int[vertices];
        bool[] visited = new bool[vertices];
        int[] parent = new int[vertices];

        for (int i = 0; i < vertices; i++)
        {
            dist[i] = int.MaxValue;
            visited[i] = false;
            parent[i] = -1;
        }
        dist[src] = 0;

        for (int count = 0; count < vertices - 1; count++)
        {
            int u = MiniDistance(dist, visited, vertices);

            visited[u] = true;

            for (int v = 0; v < vertices; v++)
            {
                if (!visited[v] && graph[u, v] != 0 &&
                    dist[u] != int.MaxValue &&
                    dist[u] + graph[u,v] < dist[v])
                {
                    dist[v] = dist[u] + graph[u, v];
                    parent[v] = u;
                }
            }
        }
        PrintSolution(dist, parent, src, vertices);
    }
    static void PrintSolution(int[] dist, int[] parent, int src, int vertices)
    {
        Console.WriteLine($"Vertex\tDistance from Source\tPath");
        for (int i = 0; i < vertices; i++)
        {
            Console.Write($"{i}\t{dist[i]}\t\t\t");
            PrintPath(parent, i);
            Console.WriteLine();
        }
    }
    static void PrintPath(int[] parent, int j)
    {
        if (parent[j] == -1)
        {
            Console.Write(j);
            return;
        }
        PrintPath(parent, parent[j]);
        Console.Write(" -> " + j);
    }
    static void Main(string[] args)
    {
        int vertices = 5;
        int[,] graph = 
        {
            {0,10,0,30,100 },
            {10,0,50,0,0 },
            {0,50,0,20,10 },
            { 30, 0, 20, 0, 60 },
            {100, 0, 10, 60, 0 }
        };
        Console.WriteLine("Dijkstra's Algorithm - shortest Path from Node 0:\n");
        Dijkstra(graph, 0, vertices);
    }
}