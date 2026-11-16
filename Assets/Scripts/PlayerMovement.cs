using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody Rb;

    // A variable so we don't need to write random numbers
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // FixedUpdate is used when we are messing with the physics system
    void FixedUpdate()
    {
        // Adds a Forward Force to our Player
        Rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            Rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        else if(Input.GetKey("a"))
        {
            Rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(Rb.position.y < -1f)
        {
            FindAnyObjectByType<GameManager>().EndGame();
        }
    }

}
