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

        }
    }
}
