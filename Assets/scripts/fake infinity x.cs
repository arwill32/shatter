using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fakeinfinityx : MonoBehaviour
{
    //establish barriers 
    //public GameObject oppositeBarrier;
    GameObject Player;
    public float distance;
    public bool positiveMovement;
    public bool negativeMovement;

    //Vector3 targetLocation;
    Vector3 playerLocation;
    Vector3 newLocation;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger");
        if (other.CompareTag("GameController") == true)
        {
            Debug.Log("trigger controller");
            Player = GameObject.FindWithTag("Player");
            //targetLocation = oppositeBarrier.transform.position;
            //Debug.Log(targetLocation);
            playerLocation = Player.transform.position;
            Debug.Log(playerLocation);
            if (positiveMovement)
            {
                newLocation = new Vector3(playerLocation.x + distance, playerLocation.y, playerLocation.z);
            }
            if (negativeMovement)
            {
                newLocation = new Vector3(playerLocation.x - distance, playerLocation.y, playerLocation.z);
            }
            Player.transform.position = (newLocation);
            Debug.Log(newLocation);
        }
    }
}
