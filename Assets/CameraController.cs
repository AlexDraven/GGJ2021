using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float sensitivity = 8.00f;
    private float rotateHorizontal, rotateVertical;
    public float speed = 5.0f;
    float smooth = 5.0f;
    float tiltAngle = 60.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotateHorizontal = Input.GetAxis("Mouse X") * tiltAngle;
        rotateVertical = Input.GetAxis("Mouse Y") * tiltAngle;
        //transform.RotateAround(transform.position, -Vector3.up, rotateHorizontal * sensitivity * Time.deltaTime); //use transform.Rotate(-transform.up * rotateHorizontal * sensitivity) instead if you dont want the camera to rotate around the player
        //  transform.RotateAround(Vector3.zero, transform.right, rotateVertical * sensitivity * Time.deltaTime); // again, use transform.Rotate(transform.right * rotateVertical * sensitivity) if you don't want the camera to rotate around the player

        //transform.Rotate(0, rotateHorizontal, 0);
        //transform.Rotate(0, rotateHorizontal, 0);
    }
    void FixedUpdate()
    {
   }
}
