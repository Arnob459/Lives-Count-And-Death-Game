using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScorePoint : MonoBehaviour
{
   //public int Respawn;
    public Text countText;
    private int count;

    [SerializeField] private Transform player;
    [SerializeField] private Transform RespawnPoint;




    void Start()
    {   
        count = 0;
        SetCountText(); 

    }
  /*  private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            SceneManager.LoadScene(Respawn);
            count = count + 1;
            SetCountText();
        }
    }*/

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            player.transform.position = RespawnPoint.transform.position;
            //Physics.SyncTransforms();
            count = count + 1;
            SetCountText();
        }
    }
    void SetCountText()
    {
        countText.text = "Score: " + count.ToString();

      
    }

}
