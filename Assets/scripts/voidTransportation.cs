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

    //list of sounds
    public AudioClip[] abyssSound;
    //public AudioSource abyssSource;
    //internal shard counter
    int shardCount;
    int index;
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource.PlayClipAtPoint(abyssSound[0], transform.position, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("shards") && shardCount < numShards)
        {
            shardCount++;
            Debug.Log(shardCount);

            index = Random.Range(0, abyssSound.Length);
            //abyssSource.Stop();
            AudioSource.PlayClipAtPoint(abyssSound[index], transform.position);
            Debug.Log("soundChange" + index);
        }

        if (other.CompareTag("GameController") && shardCount == numShards)
        {
            SceneManager.LoadScene(sceneName);
        }

    }

}
