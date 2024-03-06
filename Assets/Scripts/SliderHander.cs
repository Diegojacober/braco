using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using Microsoft.MixedReality.Toolkit.UI;
using System.Collections;
using System.Collections.Generic;
using System;



namespace Microsoft.MixedReality.Toolkit.Examples.Demos
{
    [AddComponentMenu("Scripts/MRTK/Examples/ShowSliderValue")]



    public class ControlUR5 : MonoBehaviour
    {
        // private const string apiUrl = "http://127.0.0.1:8000/receive";


        void Start()
        {
            // if (this.tag == "X")
            // {
            //     transform.Rotate(0.0f, 0.0f, 0.0f, Space.Self);
            // }
        }

        public void OnSliderUpdated(SliderEventData eventData)
        {
            float x = 0.0f;
            float y = 0.0f;
            float z = 0.0f;

            if (this.tag == "Z1")
            {
                x = 0.0f;
                y = 0.0f;
                z = (eventData.NewValue * 90f) + 45f;
                transform.rotation = Quaternion.Euler(x, y, z);
            }
            if (this.tag == "Z2")
            {
                x = 0.0f;
                y = 0.0f;
                z = (eventData.NewValue * 90f) - 45f;
                transform.rotation = Quaternion.Euler(x, y, z);
            }
            if (this.tag == "Z3")
            {
                x = 0.0f;
                y = 0.0f;
                z = (eventData.NewValue * 90f);
                transform.rotation = Quaternion.Euler(x, y, z);
            }
            if (this.tag == "X")
            {
                x = eventData.NewValue * 90f;
                y = 180.0f;
                z = 180.0f;
                transform.rotation = Quaternion.Euler(x, y, z);
            }

            if (eventData.NewValue > 0.5)
            {
                string xString = x.ToString().Replace(",", ".");
                string yString = y.ToString().Replace(",", ".");
                string zString = z.ToString().Replace(",", ".");
                string json = $"{{\"x\": \"{xString}\", \"y\": \"{yString}\", \"z\": \"{zString}\", \"component\": \"{this.name}\" }}";
                Debug.Log(json);
                StartCoroutine(SendPostRequest(json));
            }
        }

        IEnumerator SendPostRequest(string json)
        {


            using (UnityWebRequest www = UnityWebRequest.Post("http://192.168.88.54:8000/coordinates/", json, "application/json"))
            {
                Debug.Log("aasas");
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
}
