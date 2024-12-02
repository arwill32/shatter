using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class voidTransportation : MonoBehaviour
{
    //need number of shards in env
    public int numShards;
    //target env number
    public int nextEnv;

    int shardCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("shards") && shardCount < numShards)
        {
            shardCount++;
            Debug.Log(shardCount);
        }

        if (other.CompareTag("GameController") && shardCount >= numShards)
        {
            Debug.Log("next env");
            SceneManager.LoadScene(nextEnv);
        }


    }

}
