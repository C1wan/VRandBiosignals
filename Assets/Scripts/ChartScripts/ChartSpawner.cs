using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChartSpawner : MonoBehaviour
{

    public GameObject ChartCH1;
    public GameObject ChartCH2;
    public GameObject ChartCH3;
    public GameObject ChartCH4;
    public GameObject ChartCH5;
    public GameObject ChartCH6;
    public GameObject ChartCH7;
    public GameObject ChartCH8;

    public Button ButtonCH1;
    public Button ButtonCH2;
    public Button ButtonCH3;
    public Button ButtonCH4;
    public Button ButtonCH5;
    public Button ButtonCH6;
    public Button ButtonCH7;
    public Button ButtonCH8;
  
    // Start is called before the first frame update
    void Start()
    {
        ChartCH1.SetActive(false);
    }

   public void SpawnChartOnButtonPress(){

        ChartCH1.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
