using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateControl1 : MonoBehaviour
{
    public MeshRenderer angleSliderNumberControl1;

    void Update()
    {
        
        this.transform.rotation = Quaternion.Euler(0, 0,float.Parse(angleSliderNumberControl1.ToString()) *10f);
    }
}
