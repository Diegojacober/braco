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
        private const string apiUrl = "http://127.0.0.1:8000/receive";

        public void OnSliderUpdated(SliderEventData eventData)
        {
            transform.rotation = Quaternion.Euler(0, 0, eventData.NewValue * 100f);
            Debug.Log(this);

            if (eventData.NewValue > 0.5)
            {
                float x = 1.0f; 
                float y = 2.0f;
                float z = 3.0f;

                string json = $"{{\"x\": {x}, \"y\": {y}, \"z\": {z}}}";

                StartCoroutine(SendPostRequest(json));
            }
        }

        IEnumerator SendPostRequest(string json)
    {
        using (UnityWebRequest www = UnityWebRequest.Post("http://127.0.0.1:8000/receive", json , "application/json"))
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
}
