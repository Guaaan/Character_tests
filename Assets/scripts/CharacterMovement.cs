using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed = 1.0f;
    public float rotationSpeed = 1.0f;

    private Rigidbody Psychics;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        Psychics = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //movimiento
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horizontal, 0.0f, vertical) * Time.deltaTime * speed);   

        //rotacion
        float rotationY = Input.GetAxis("Mouse X");
        transform.Rotate(new Vector3(0.0f, rotationY, 0.0f));
        // float rotationX = Input.GetAxis("Mouse Y");
        // transform.Rotate(new Vector3(-rotationX, 0.0f, 0.0f));

        //salto
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Psychics.AddForce(new Vector3(0.0f, 5.0f, 0.0f), ForceMode.Impulse);
        }
    }

}
