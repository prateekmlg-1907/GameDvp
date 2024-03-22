using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid2D : MonoBehaviour
{
    public GameObject square;
    public int Width = 5;
    public int Height = 5;
    public float padding = 1.3f;
    void Start()
    {
    SpawnGrid();
    }
    void SpawnGrid()
    {
        for (int x = 0; x < Width; x++)
        {
            for (int y = 0; y < Height; y++)
            {
                Vector2 spawn = new Vector2(x * padding, y * padding);
                Instantiate(square, spawn, Quaternion.identity,transform);
            }
        }
    }
}