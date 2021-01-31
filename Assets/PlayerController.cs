using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Camera camera; 
    private float horizontalMove, verticalMove;
    private float camX, camY;
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");
        camY = Input.GetAxis("Mouse Y");
        camX = Input.GetAxis("Mouse X");
      if(horizontalMove != 0 || verticalMove != 0)
        {
            transform.Translate(new Vector3(0, 0, verticalMove) * Time.deltaTime * speed, Space.Self);
        }
      if(camY != 0 || camX != 0)
        {
            transform.Rotate(0, camX, 0, Space.World);
            var rotateValue = new Vector3(camY, camX * -1, 0);
         //   camera.transform.eulerAngles = camera.transform.eulerAngles - rotateValue; 

        }
    }
     
    void FixedUpdate() 
    {
 
    } 
}
