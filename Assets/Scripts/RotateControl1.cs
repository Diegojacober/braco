using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateControl1 : MonoBehaviour
{
    public Slider rotationControl1;

    private float angleSliderNumberControl1;

    void Update()
    {
        angleSliderNumberControl1 = rotationControl1.value * 10f;
        this.transform.rotation = Quaternion.Euler(0, 0, angleSliderNumberControl1);
    }
}
