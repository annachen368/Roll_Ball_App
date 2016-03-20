using UnityEngine;
using System.Collections;

public class Player_controller : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    public Button joystick;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        // float moveHorizontal = Input.GetAxis("Horizontal");
        // float moveVertical = Input.GetAxis("Vertical");
        float moveHorizontal = joystick.Horizontal();
        float moveVertical = joystick.Vertical();

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
        //Debug.Log("Hey what's up!");
    }

}