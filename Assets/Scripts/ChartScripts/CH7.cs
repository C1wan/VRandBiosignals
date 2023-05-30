using System.Threading;
using System.Runtime.Serialization;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XCharts;
using System.Reflection;
using Random = System.Random;

// Class for creating Chart for channel 1
public class CH7 : MonoBehaviour
{
    public static float valueFromClass;
    float elapsed = 0f;
    public float INTERVAL = 1f;
    // Number of how much data can be shown to each graph
    public int maxCache = 100;
    private float m_LastTime = 0f;
    private LineChart chart;

    [SerializeField]
    private Color chartColor;

    [SerializeField]
    private Color lineColor;

    [SerializeField]
    private float lineWidth;

    void Awake()
    {
        chart = gameObject.GetComponent<LineChart>();
        createChart();
        chart.SetMaxCache(maxCache);
        chartColor = Color.black;
        lineColor = Color.black;
        lineWidth = 2;
    }

    // Method which creates the chart -> parameters can be changed and some additions can be made
    void createChart()
    {
        if (chart == null)
        {
            chart = gameObject.AddComponent<LineChart>();
        }
        chart.title.show = true;
        chart.title.text = "CH7";
        chart.title.location.right = -15;
        chart.title.location.align = Location.Align.CenterRight;
        chart.theme.backgroundColor = Color.clear;
        chart.RemoveData();
        chart.AddSerie(SerieType.Line);
        chart.theme.serie.lineSymbolSize = 0;
        chart.yAxes[0].minMaxType = Axis.AxisMinMaxType.Custom;
        chart.yAxes[0].max = 65535;


        // lineColor
        chart.theme.colorPalette[0] = lineColor;
        // chart Color
        chart.theme.title.textColor = chartColor;
        chart.theme.axis.textColor = chartColor;
        chart.theme.axis.lineColor = chartColor;
        chart.theme.axis.tickColor = chartColor;
        chart.theme.serie.lineWidth = lineWidth;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Gets data from the Hybrid8Test class and adds it to the line of the chart
    void Update()
    {
        valueFromClass = Hybrid8Test.valueCH7;
        if (Time.realtimeSinceStartup - m_LastTime >= INTERVAL)
        {
            // Random ra = new Random();
            // int rInt = ra.Next(1000, 66000);
            m_LastTime = Time.realtimeSinceStartup;
            // chart.AddData(0, rInt);
            chart.AddData(0, valueFromClass);
        }
        elapsed += Time.deltaTime;
        if (elapsed >= 1f)
        {
            elapsed = elapsed % 1f;
        }
    }
}
