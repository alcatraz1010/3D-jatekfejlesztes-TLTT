using UnityEngine;

public class PlayerCollison : MonoBehaviour
{
    public PlayerMovement movement;
 
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "obsticle")
        {
            movement.enabled = false;
       
            FindObjectOfType<GameManager>().EndGame();
        }
    }


}
