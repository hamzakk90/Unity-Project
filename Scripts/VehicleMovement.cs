using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    private float speed = 20f;
    private float turnSpeed = 40f;
    private float horizontalInput;
    private float forwardInput;
    public Camera TPPCamera;
    public Camera FPPCamera;
    public KeyCode switchKey;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        
        if(Input.GetKeyDown(switchKey))
            {
                TPPCamera.enabled = !TPPCamera.enabled;
                FPPCamera.enabled = !FPPCamera.enabled;
            }

    }
}
