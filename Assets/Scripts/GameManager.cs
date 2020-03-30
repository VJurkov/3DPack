using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   public void CollisionDetected(Collision collision,FPController player)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(player.gameObject);
            // TODO game overscreen
        }

        if (collision.gameObject.CompareTag("Collectable"))
        {
            Destroy(collision.gameObject);
            // TODO add score counting
        }
    }
    
}
