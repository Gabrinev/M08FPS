using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public Transform player;
    public float MouseSensy;
    float x;
    float y;


    // Start is called before the first frame update
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    private void Update()
    {
        x -= Input.GetAxis("Mouse Y") * MouseSensy;
        y += Input.GetAxis("Mouse X") * MouseSensy;
         
        x = Mathf.Clamp(x, -90, 90);
        

        transform.localRotation = Quaternion.Euler(x,0,0);
        player.transform.localRotation = Quaternion.Euler(0, y, 0);
    }
}
