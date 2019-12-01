using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xSpin = Random.Range(0,5);
        float ySpin = Random.Range(0,5);
        float zSpin = Random.Range(0,5);
        transform.Rotate(xSpin,ySpin,zSpin);    
    }
}