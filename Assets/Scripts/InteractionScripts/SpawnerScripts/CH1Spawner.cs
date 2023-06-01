using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CH1Spawner : MonoBehaviour
{
    public GameObject CubeSize;
    public GameObject CubeColor;
    public GameObject SphereSize;
    public GameObject SphereColor;
    public GameObject target;
    public GameObject target2;
    public GameObject target3;
    public GameObject fire;
    public GameObject fireNeast;
    public GameObject fireDragon;
    private Vector3 scaleChangeFireDragonMin;
    private Vector3 scaleChangeFireMin;
    private Vector3 scaleChangeTargetMin;
    private Vector3 scaleChangeTargetMax;
    private Vector3 scaleChangeFireMax;
    private Vector3 scaleChangeFireDragonMax;
    public Button button;
    private Vector3 scaleChange;
    private Vector3 scaleChangeMin;
    private float desiredQuantitySize;
    private float currentQuantitySize;
    private float MovementPerSecond = 0.5f;
    public static float valueFromClass;
    // Start is called before the first frame update
    void Start()
    {
        scaleChange = new Vector3(1, 1, 1);
        scaleChangeMin = new Vector3(0.2f, 0.2f, 0.2f);

        scaleChangeFireDragonMax = new Vector3(10f, 10f, 10f);
        scaleChangeTargetMin = new Vector3(0.5f, 0.5f, 0.5f);
        scaleChangeFireMin = new Vector3(1f, 1f, 1f);
        scaleChangeTargetMax = new Vector3(1.5f, 1.5f, 1.5f);
        scaleChangeFireMax = new Vector3(8f, 8f, 8f);
        scaleChangeFireDragonMin = new Vector3(1f, 1f, 1f);



        currentQuantitySize = 0.5f;
        desiredQuantitySize = currentQuantitySize;
        CubeSize.SetActive(false);
        CubeColor.SetActive(false);
        SphereSize.SetActive(false);
        SphereColor.SetActive(false);
    }

    void ProcessMovementSize()
    {
        currentQuantitySize = Mathf.MoveTowards(
            currentQuantitySize,
            desiredQuantitySize,
            MovementPerSecond * Time.deltaTime);
    }
    void ChangeCubeSize(int value)
    {
        switch (value)
        {
            case <= 0:
                desiredQuantitySize = 0.0001f;
                break;

            case > 0 and <= 3276:
                if (desiredQuantitySize > 0.25f)
                {
                    desiredQuantitySize = 0.25f;
                    break;
                }
                desiredQuantitySize = 0.05f;
                break;

            case > 3276 and <= 6553:
                if (desiredQuantitySize > 0.3f)
                {
                    desiredQuantitySize = 0.3f;
                    break;
                }
                desiredQuantitySize = 0.1f;
                break;

            case > 6553 and <= 9829:
                if (desiredQuantitySize > 0.35f)
                {
                    desiredQuantitySize = 0.35f;
                    break;
                }
                desiredQuantitySize = 0.15f;
                break;

            case > 9829 and <= 13107:
                if (desiredQuantitySize > 0.4f)
                {
                    desiredQuantitySize = 0.4f;
                    break;
                }
                desiredQuantitySize = 0.2f;
                break;
            case > 13107 and <= 16382:
                if (desiredQuantitySize > 0.45f)
                {
                    desiredQuantitySize = 0.45f;
                    break;
                }
                else if (desiredQuantitySize < 0.05f)
                {
                    desiredQuantitySize = 0.05f;
                    break;
                }
                desiredQuantitySize = 0.25f;
                break;

            case > 16382 and <= 19660:
                if (desiredQuantitySize > 0.5f)
                {
                    desiredQuantitySize = 0.5f;
                    break;
                }
                else if (desiredQuantitySize < 0.1f)
                {
                    desiredQuantitySize = 0.1f;
                    break;
                }
                desiredQuantitySize = 0.3f;
                break;

            case > 19660 and <= 22935:
                if (desiredQuantitySize > 0.55f)
                {
                    desiredQuantitySize = 0.55f;
                    break;
                }
                else if (desiredQuantitySize < 0.15f)
                {
                    desiredQuantitySize = 0.15f;
                    break;
                }
                desiredQuantitySize = 0.35f;
                break;

            case > 22935 and <= 26214:
                if (desiredQuantitySize > 0.6f)
                {
                    desiredQuantitySize = 0.6f;
                    break;
                }
                else if (desiredQuantitySize < 0.2f)
                {
                    desiredQuantitySize = 0.2f;
                    break;
                }
                desiredQuantitySize = 0.4f;
                break;

            case > 26214 and <= 29488:
                if (desiredQuantitySize > 0.65f)
                {
                    desiredQuantitySize = 0.65f;
                    break;
                }
                else if (desiredQuantitySize < 0.25f)
                {
                    desiredQuantitySize = 0.25f;
                    break;
                }
                desiredQuantitySize = 0.45f;
                break;

            case > 29488 and <= 32767: // H�LFTE
                if (desiredQuantitySize > 0.7f)
                {
                    desiredQuantitySize = 0.7f;
                    break;
                }
                else if (desiredQuantitySize < 0.3f)
                {
                    desiredQuantitySize = 0.3f;
                    break;
                }
                desiredQuantitySize = 0.5f;
                break;

            case > 32767 and <= 36041: //H�LFTE
                if (desiredQuantitySize < 0.35f)
                {
                    desiredQuantitySize = 0.35f;
                    break;
                }
                else if (desiredQuantitySize > 0.75f)
                {
                    desiredQuantitySize = 0.75f;
                    break;
                }
                desiredQuantitySize = 0.55f;
                break;

            case > 36041 and <= 39321:
                if (desiredQuantitySize < 0.4f)
                {
                    desiredQuantitySize = 0.4f;
                    break;
                }
                else if (desiredQuantitySize > 0.8f)
                {
                    desiredQuantitySize = 0.8f;
                    break;
                }
                desiredQuantitySize = 0.6f;
                break;

            case > 39321 and <= 42594:
                if (desiredQuantitySize < 0.45f)
                {
                    desiredQuantitySize = 0.45f;
                    break;
                }
                else if (desiredQuantitySize > 0.85f)
                {
                    desiredQuantitySize = 0.85f;
                    break;
                }
                desiredQuantitySize = 0.65f;
                break;

            case > 42594 and <= 45874:
                if (desiredQuantitySize < 0.5f)
                {
                    desiredQuantitySize = 0.5f;
                    break;
                }
                else if (desiredQuantitySize > 0.9f)
                {
                    desiredQuantitySize = 0.9f;
                    break;
                }
                desiredQuantitySize = 0.7f;
                break;

            case > 45874 and <= 49147:
                if (desiredQuantitySize < 0.55f)
                {
                    desiredQuantitySize = 0.55f;
                    break;
                }
                else if (desiredQuantitySize > 0.95f)
                {
                    desiredQuantitySize = 0.95f;
                    break;
                }
                desiredQuantitySize = 0.75f;
                break;

            case > 49147 and <= 52428:
                if (desiredQuantitySize < 0.6f)
                {
                    desiredQuantitySize = 0.6f;
                    break;
                }
                desiredQuantitySize = 0.8f;
                break;

            case > 52428 and <= 55700:
                if (desiredQuantitySize < 0.65f)
                {
                    desiredQuantitySize = 0.65f;
                    break;
                }
                desiredQuantitySize = 0.85f;
                break;

            case > 55700 and <= 58981:
                if (desiredQuantitySize < 0.7f)
                {
                    desiredQuantitySize = 0.7f;
                    break;
                }
                desiredQuantitySize = 0.9f;
                break;

            case > 58981 and <= 62253:
                if (desiredQuantitySize < 0.75f)
                {
                    desiredQuantitySize = 0.75f;
                    break;
                }
                desiredQuantitySize = 0.95f;
                break;

            case > 62553 and <= 65535:
                if (desiredQuantitySize < 0.8f)
                {
                    desiredQuantitySize = 0.8f;
                    break;
                }
                desiredQuantitySize = 1.0f;
                break;
        }

        CubeSize.transform.localScale = Vector3.Lerp(scaleChange, scaleChangeMin, currentQuantitySize);
        CubeColor.GetComponent<Renderer>().material.color = Color.Lerp(Color.red, Color.green, currentQuantitySize);
        SphereSize.transform.localScale = Vector3.Lerp(scaleChange, scaleChangeMin, currentQuantitySize);
        SphereColor.GetComponent<Renderer>().material.color = Color.Lerp(Color.red, Color.yellow, currentQuantitySize);
        target.transform.localScale = Vector3.Lerp(scaleChangeTargetMin, scaleChangeTargetMax, currentQuantitySize);
        fire.transform.localScale = Vector3.Lerp(scaleChangeFireMin, scaleChangeFireMax, currentQuantitySize);
        target2.transform.localScale = Vector3.Lerp(scaleChangeTargetMin, scaleChangeTargetMax, currentQuantitySize);
        target3.transform.localScale = Vector3.Lerp(scaleChangeTargetMin, scaleChangeTargetMax, currentQuantitySize);
       fireDragon.transform.localScale = Vector3.Lerp(scaleChangeFireDragonMin, scaleChangeFireDragonMax, currentQuantitySize);
        fireNeast.transform.localScale = Vector3.Lerp(scaleChangeFireMin, scaleChangeFireMax, currentQuantitySize);

    }
   public void SpawnObjects()
    {

        CubeSize.SetActive(true);
        CubeColor.SetActive(true);
        SphereSize.SetActive(true);
        SphereColor.SetActive(true);
        button.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        valueFromClass = Hybrid8Test.valueCH1;
        ProcessMovementSize();
        ChangeCubeSize((int)valueFromClass);

    }
}
