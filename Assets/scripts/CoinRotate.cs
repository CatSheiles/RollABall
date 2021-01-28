using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotate : MonoBehaviour
{
    public float rotationSpeed = 5;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotationAmount = new Vector3(2, 3, 1);
        transform.Rotate(rotationAmount * Time.deltaTime * rotationSpeed);
    }
}
