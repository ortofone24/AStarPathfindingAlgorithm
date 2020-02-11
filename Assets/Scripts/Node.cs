using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : IHeapItem<Node>
{
    public bool Walkable;
    public Vector3 WorldPosition;
    public int GridX;
    public int GridY;

    public int gCost;
    public int hCost;
    public Node parent;
    int heapIndex;

    public Node(bool walkable, Vector3 worldPos, int gridX, int gridY)
    {
        Walkable = walkable;
        WorldPosition = worldPos;
        GridX = gridX;
        GridY = gridY;
    }

    public int fCost //we want only get the fcost from return gCost + hCost
    {
        get 
        {
            return gCost + hCost;
        }
    }

    public int HeapIndex 
    { 
        get
        {
            return heapIndex;
        }
        set
        {
            heapIndex = value;
        }
    }

    public int CompareTo(Node nodeToCompare)
    {
        int compare = fCost.CompareTo(nodeToCompare.fCost);
        if(compare == 0)
        {
            compare = hCost.CompareTo(nodeToCompare.hCost);
        }
        return -compare;
    }
}
