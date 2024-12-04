using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructable : MonoBehaviour
{
    public GameObject destroyedVersion;  // The destroyed version of the object

    void OnCollisionEnter(Collision collision)
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object collides with the player (the object must have the "GameController" tag)
        if (other.gameObject.CompareTag("GameController"))
        {
            // Instantiate the destroyed version at the position and rotation of the current object
            Instantiate(destroyedVersion, transform.position, transform.rotation);

            // Destroy the current object (this will remove the object from the scene)
            Destroy(gameObject);
        }
    }
}
