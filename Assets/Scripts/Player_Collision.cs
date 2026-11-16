using UnityEngine;

public class Player_Collision : MonoBehaviour
{

    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindAnyObjectByType<GameManager>().EndGame();
        }
    }
}
