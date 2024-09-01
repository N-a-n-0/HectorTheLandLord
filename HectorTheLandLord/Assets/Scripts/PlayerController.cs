using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody theRB;

    public float moveSpeed = 5f;

    public Vector3 moveInput; //X and Y value

    public Vector2 mouseInput;

    public float mouseSensitivity = 1f;

    public Transform viewCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = new Vector3(Input.GetAxis("Horizontal"),0, Input.GetAxis("Vertical"));
        Vector3 moveVertical = transform.forward * moveInput.z;
        Vector3 moveHorizontal = transform.right * moveInput.x;

        theRB.velocity = (moveHorizontal + moveVertical) * moveSpeed;

        mouseInput = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y")) * mouseSensitivity;
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y - mouseInput.x, transform.rotation.eulerAngles.z);

        viewCamera.localRotation = Quaternion.Euler(viewCamera.localRotation.eulerAngles + new Vector3(0f, mouseInput.y, 0f));
    }
}
