using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTest : MonoBehaviour
{
    public bool Closed = true;
    Animation dooranim;
    // Start is called before the first frame update
    void Start()
    {
        dooranim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            if (Closed == true)//Opens door if it's closed
            {
                dooranim.Play("DoorOpen");
                Closed = false;
            }
            else if (Closed == false)//and vice versa
            {
                dooranim.Play("DoorClose");
                Closed = true;
            }
        }
        
    }
}
