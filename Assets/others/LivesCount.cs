using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesCount : MonoBehaviour
{
    public Image[] lives;
    public int livesRemaining;


    public void LoseLife()
    {

        if (livesRemaining == 0)
        {
            return;
        }
        livesRemaining--;
        //hide one of the image obj
        lives[livesRemaining].enabled = false;

        if (livesRemaining == 0)
        {
            FindObjectOfType<LevelManager>().Restart();


        }
    }

    public void Update()
    {
        
            LoseLife();
       
    }





}
