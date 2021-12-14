using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class look : MonoBehaviour
{
    public Transform cam;
    public Transform player;
    float mouseX, mouseY;
    float MouseY{
        get => mouseY;
        set => mouseY = Mathf.Clamp(value, -90, 90);
    }
     float MouseX{
        get => mouseX;
        set => mouseX = value % 360;
    }
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        MouseX += Input.GetAxis("Mouse X");
        player.rotation = Quaternion.Euler(0, MouseX, 0);

        //rotates only cam about its local x-axis
        MouseY += Input.GetAxis("Mouse Y");
        cam.rotation = Quaternion.Euler(-MouseY, cam.rotation.eulerAngles.y, 0);
    }
}
