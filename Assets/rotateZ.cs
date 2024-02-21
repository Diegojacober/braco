using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class rotateZ : MonoBehaviour
{
    public float speed;
    public Rigidbody rig;
    float direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direction = Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {
        rig.transform.Rotate(0, 0, direction * 10);
    }
}
