using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CellularAutomata : MonoBehaviour
{
    [Header("Tiles")]
    [SerializeField] private Tilemap tilemap;
    [SerializeField] Tile tileVivante;
    [SerializeField] Tile tileMorte;
    [SerializeField] float WaterPercent=3;
    [SerializeField] int SmoothingIterations = 3;
    [SerializeField] double K = 3;

    const int sizeMap = 100;

    int[,] isWater;

    void Start()
    {
        Generate();
    }

    int[,] Smooth (int[,] map)
    {
        System.Random rand = new System.Random();
        int[,] newMap = new int[map.GetLength(0), map.GetLength(1)];

        int Sum (int x, int y)
        {
            return map[x - 1, y - 1] + map[x, y - 1] + map[x + 1, y - 1]
                + map[x, y - 1] + map[x, y] + map[x, y + 1]
                + map[x + 1, y - 1] + map[x, y] + map[x + 1, y + 1];
        }

        for (int i = 1; i < map.GetLength(0)-1; i++)
        {
            for (int j = 1; j < map.GetLength(1) - 1; j++)
            {
                double x = Sum(i, j) / 9.0;
                double fOfX = 1 / (1 + System.Math.Pow(System.Math.E, -K * (x - .5)));
                
                if (fOfX > rand.NextDouble())
                {
                    newMap[i, j] = 1;
                }
                else
                {
                    newMap[i, j] = 0;
                }
            }
        }
        return newMap;
    }

    void Generate()
    {
        isWater = new int[sizeMap, sizeMap];

        System.Random rand = new System.Random();
        for (int i = 0; i < sizeMap; i++)
        {
            for (int j = 0; j < sizeMap; j++)
            {
                isWater[i, j] = rand.NextDouble () <= WaterPercent? 1 : 0;
            }
        }

        for (int i = 0; i < SmoothingIterations; i++)
        {
            isWater = Smooth(isWater);
        }

        for (int i = 0; i < sizeMap; i++)
        {
            for (int j = 0; j < sizeMap; j++)
            {
                tilemap.SetTile(new Vector3Int(i, j, 0), isWater[i,j] == 1? tileVivante : tileMorte);
            }
        }
   
    }
    //// Update is called once per frame
    //void Update()
    //{
      
    //}
}
