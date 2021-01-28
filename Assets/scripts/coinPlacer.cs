using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinPlacer : MonoBehaviour
{
    public Transform[] coins;
    public float circleSize = 5f;

    Vector2 generateCoordinates(int k, float r, int n)
    {
        float a = (2 * Mathf.PI) / n;
        
        float x = r * Mathf.Cos(k * a);
        float y = r * Mathf.Sin(k * a);

        return new Vector2(x, y);
    }

    private void Start()
    {
        for (int i = 0; i < coins.Length; i++)
        {
            Vector2 position = generateCoordinates(i, circleSize, coins.Length);
            coins[i].position = new Vector3(position.x, 0.5f, position.y);
        }
    }
}
