using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    public AudioClip clip;
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
        if (other.transform.tag == "Player")//Plays audio when attached object collides with player.
        {
            AudioSource.PlayClipAtPoint(clip, new Vector3(0, 0, 0));//PlayClipAtPoint creates another object to play the audio from as the pickup objects are destroyed
        }
    }
}
