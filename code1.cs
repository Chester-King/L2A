using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class TrumpController : MonoBehaviour
{
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = CrossPlatformInputManager.GetAxis("Horizontal");
        float y = CrossPlatformInputManager.GetAxis("Vertical");
        // x and y gives a value between -1 and 1
        Vector3 movement = new Vector3(x, 0, y);
        // Translating the 2D movement of the Joystic to the 3D movement

        rb.velocity = movement * 4f;
        // Change the value of 4f if you want it to go faster or slower

        if(x!=0 && y != 0)
        {
            // Changing roation about the y
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, Mathf.Atan2(x,y)*Mathf.Rad2Deg , transform.eulerAngles.z);
            // Atan2 gives us the angle which is found using slope
        }
    }
}
