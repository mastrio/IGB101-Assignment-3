using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stars : MonoBehaviour
{
    public ParticleSystem stars;
    GameManager gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }
    // Update is called once per frame
    void Update()
    {
        StarCheck();
    }
    private void StarCheck()
    {
        if (gameManager.levelComplete == true)
        {
            stars.Play();
        }
        else
        {
            stars.Pause();
        }
    }
}
