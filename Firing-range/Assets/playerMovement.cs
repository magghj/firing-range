using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float moveingForce = 70f;



    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, moveingForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -moveingForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(moveingForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-moveingForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a") && Input.GetKey("b") || Input.GetKey("w") && Input.GetKey("s") == true)
        {
            rb.velocity = new Vector3(0, rb.velocity.y, rb.velocity.z);
        }
    }
}
