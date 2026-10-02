using System;
using UnityEngine;

public class EnvironmentHealth : MonoBehaviour
{
    
    [SerializeField] int health = 3;
    [SerializeField] PlayerController playerController;
    
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Axe"))
        {
            health -= 1;

            if (health <= 0)
            {
                playerController.ReturnAxeNow();
            }

        }
    }
}
