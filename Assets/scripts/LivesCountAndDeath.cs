using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LivesCountAndDeath : MonoBehaviour
{
    public Image[] lives;
    public int livesRemaining = 3;

    [SerializeField] private Transform player;
    [SerializeField] private Transform RespawnPoint;


 

    public void start()
    {
        //livesRemaining = 0;
        LoseLife();

    }
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
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);


        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            
            player.transform.position = RespawnPoint.transform.position;
            //Physics.SyncTransforms();
            LoseLife();



        }
    }

}
