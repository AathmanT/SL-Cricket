using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joint_HipLT : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log(transform.localEulerAngles.x.ToString() + ", " + transform.localEulerAngles.y.ToString() + ", " + transform.localEulerAngles.z.ToString());
    }

    void OnMouseOver() {
        Debug.Log("adsf");
    }
}
