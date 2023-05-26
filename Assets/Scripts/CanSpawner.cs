using System.Collections;
using Random = System.Random;
using System.Collections.Generic;
using UnityEngine;

public class CanSpawner : MonoBehaviour
{
    private float[] values = new float[3];
    private float valueCH1;


    public GameObject colaCan;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        valueCH1 = Hybrid8Test.valueCH1;
        Random ra = new Random();
        float rInt = ra.Next(1000, 65000);

    }
}
