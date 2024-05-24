using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTest : MonoBehaviour
{
    public bool Closed = true;
    Animation door;
    // Start is called before the first frame update
    void Start()
    {
        door = GetComponent<Animation>();
        door["DoorOpen"].layer = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            if (Closed == true)
            {   
                door.Play("DoorOpen");
                Closed = false;
            }
            else if (Closed == false)
            {
                door.Play("DoorClose");
                Closed = true;
            }
        }
        
    }
}
