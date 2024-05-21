using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideDoor : MonoBehaviour
{
    public GameObject doorModel;

    Animation doorAnim;

    bool doorOpened = false;

    void Start()
    {
        doorAnim = doorModel.GetComponent<Animation>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player" && !doorOpened)
        {
            doorAnim.Play();
            doorOpened = true;
        }
    }
}
