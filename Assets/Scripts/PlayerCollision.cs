using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    

    void OnCollisionEnter(Collision Collisioninfo)
    {
        if (Collisioninfo.collider.tag == "Wall")
        {
            FindObjectOfType<GameManager>().GameOver();
        }
        
    }
}
