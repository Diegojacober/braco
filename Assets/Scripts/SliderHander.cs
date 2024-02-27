using Microsoft.MixedReality.Toolkit.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Microsoft.MixedReality.Toolkit.Examples.Demos
{
    [AddComponentMenu("Scripts/MRTK/Examples/ShowSliderValue")]
    public class ControlUR5 : MonoBehaviour
    {
        public void OnSliderUpdated(SliderEventData eventData)
        {
            this.transform.rotation = Quaternion.Euler(0, 0, eventData.NewValue * 100f);
        }
    }
}