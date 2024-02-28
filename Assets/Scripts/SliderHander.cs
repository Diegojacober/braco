using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using Microsoft.MixedReality.Toolkit.UI;
using System.Collections;
using System.Collections.Generic;



namespace Microsoft.MixedReality.Toolkit.Examples.Demos
{
    [AddComponentMenu("Scripts/MRTK/Examples/ShowSliderValue")]



    public class ControlUR5 : MonoBehaviour
    {
        // private const string apiUrl = "http://127.0.0.1:8000/receive";


        void Start()
        {
            if (this.tag == "X")
            {
                transform.Rotate(0.0f, 0.0f, 0.0f, Space.Self);
            }
        }

        public void OnSliderUpdated(SliderEventData eventData)
        {

            if (this.tag == "Z")
            {
                transform.rotation = Quaternion.Euler(0.0f, 0.0f, eventData.NewValue * 360f);
            }
            if (this.tag == "X")
            {
                transform.rotation = Quaternion.Euler(eventData.NewValue * 360f, 90.0f, 90.0f);
                // transform.Rotate(90.0f, 0.0f, 0.0f, Space.Self)
            }
            // switch (this.tag)
            // {
            //     case "Z":
            //         transform.rotation = Quaternion.Euler(1, 1, eventData.NewValue * 360f);
            //         break;

            //     case "X":
            //         transform.rotation = Quaternion.Euler(eventData.NewValue * 360f, 1, 1);
            //         Debug.Log(transform.localRotation.eulerAngles.x);
            //         Debug.Log(transform.localRotation.eulerAngles.y);
            //         Debug.Log(transform.localRotation.eulerAngles.z);
            //         break;

            //     case "Y":
            //         transform.rotation = Quaternion.Euler(1, eventData.NewValue * 360f, 1);
            //         break;

            //     default:
            //         Debug.Log("Ta errado");
            //         break;
            // }

            // if (eventData.NewValue > 0.5)
            // {
            //     float x = 1.0f;
            //     float y = 2.0f;
            //     float z = 3.0f;

            //     string json = $"{{\"x\": {x}, \"y\": {y}, \"z\": {z}}}";

            //     StartCoroutine(SendPostRequest(json));
            // }
        }

        // IEnumerator SendPostRequest(string json)
        // {
        //     using (UnityWebRequest www = UnityWebRequest.Post("http://127.0.0.1:8000/receive", json, "application/json"))
        //     {
        //         yield return www.SendWebRequest();

        //         if (www.result != UnityWebRequest.Result.Success)
        //         {
        //             Debug.LogError(www.error);
        //         }
        //         else
        //         {
        //             Debug.Log("Form upload complete!");
        //         }
        //     }
        // }
    }
}
