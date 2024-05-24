using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Victory : MonoBehaviour{

    public Animator anim;

    GameManager gameManager;

    public bool OnceOnly = true;

    // Start is called before the first frame update
    void Start(){
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update(){

        Celebrate();

    }
    private void Celebrate()
    {
        if (gameManager.levelComplete == true)
        {
            if (OnceOnly == true)
                {
                anim.SetBool("Victory", true);
                OnceOnly = false;
            }
            else
            {
                anim.SetBool("Victory", false);
            }
        
        }
    }
}
