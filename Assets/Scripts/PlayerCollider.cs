using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        
        if(other.tag == "LevelCollider"){
            FindObjectOfType<PlayerController>().canMove = false;
            FindObjectOfType<PlayerController>().se2d.speed = 0f;
            FindObjectOfType<PlayerController>().playerState = false;
            Debug.Log("Player has collided with ground");
            Invoke("restartLevel", 1f);
        }
        else if(other.tag == "LevelFinishCollider"){
            FindObjectOfType<PlayerController>().canMove = false;
            FindObjectOfType<PlayerController>().se2d.speed = 3f;
            Invoke("restartLevel", 1f);
        }
    }

    private void restartLevel(){
        SceneManager.LoadScene(0);
    }
}
