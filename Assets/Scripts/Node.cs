using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node 
{
    public bool Walkable;
    public Vector3 WorldPosition;
    public int GridX;
    public int GridY;

    public int gCost;
    public int hCost;
    public Node parent;

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
}
