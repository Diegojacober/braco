using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using Microsoft.MixedReality.Toolkit.UI;



public class ButtonPressed : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        // GameObject ctrl1 = GameObject.FindGameObjectsWithTag("ctrl1")[0];
        // Debug.Log(ctrl1);
    }

    void Update()
    {
        // Teste();
    }

    public void OnClick()
    {
        Teste();
    }

    private void Teste()
    {
        // Getting all the Sliders objects
        GameObject ctrl1 = GameObject.FindGameObjectsWithTag("sliderCtrlZ1")[0];
        GameObject ctrl2 = GameObject.FindGameObjectsWithTag("sliderCtrlZ2")[0];
        GameObject ctrl3 = GameObject.FindGameObjectsWithTag("sliderCtrlZ3")[0];
        // GameObject ctrl4 = GameObject.FindGameObjectsWithTag("sliderCtrlZ4")[0];

        // Rounding all slider values to 2 decimal cases 
        float sliderZ1 = (float)Math.Round(ctrl1.GetComponent<PinchSlider>().SliderValue, 2);
        float sliderZ2 = (float)Math.Round(ctrl2.GetComponent<PinchSlider>().SliderValue, 2);
        float sliderZ3 = (float)Math.Round(ctrl3.GetComponent<PinchSlider>().SliderValue, 2);
        // float sliderZ4 = (float)Math.Round(ctrl4.GetComponent<PinchSlider>().SliderValue, 2);

        // converting slider value (0 - 1) to degrees (-45° - 135°)
        float controlZ1 = -135 + (sliderZ1 * 90);
        float controlZ2 = -135 + (sliderZ2 * 90);
        float controlZ3 = -45 - (sliderZ3 * 90);
        // float controlZ4 = -135 + (sliderZ4 * 90);
        float controlZ4 = 0;

        string controlZ1String = controlZ1.ToString().Replace(",", ".");
        string controlZ2String = controlZ2.ToString().Replace(",", ".");
        string controlZ3String = controlZ3.ToString().Replace(",", ".");
        string controlZ4String = controlZ4.ToString().Replace(",", ".");
        string json = $"{{\"control1\": \"{controlZ1String}\", \"control2\": \"{controlZ2String}\", \"control3\": \"{controlZ3String}\", \"control4\": \"{controlZ4String}\" }}";
        Debug.Log(json);
        StartCoroutine(SendPostRequest(json));

    }

    IEnumerator SendPostRequest(string json)
    {


        using (UnityWebRequest www = UnityWebRequest.Post("http://192.168.88.81:8000/coordinates", json, "application/json"))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.LogError(www.error);
            }
            else
            {
                Debug.Log("Form upload complete!");
            }
        }

    }


}
