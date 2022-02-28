using UnityEngine;
using UnityEngine.SceneManagement;

public class Flag : MonoBehaviour
{
    int noOfballs,count =1 ;
    GameObject player;

    private void Start() {
        player = GameObject.FindWithTag("Player1");
        Debug.Log( "NoOfBalls" +noOfballs);
        Debug.Log(count);
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(player.tag == "Player1" && noOfballs != 2) {
            noOfballs += count;
            Debug.Log(noOfballs);
        }
        else if(noOfballs == 2) {
            Debug.Log("Captured");
            UIManager.instance.winPanel.SetActive(true);
            UIManager.instance.retry.enabled = false;
            UIManager.instance.pauseBtn.enabled = false;
            Time.timeScale = 0;
            

        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        if(player.tag == "Player1") {
            noOfballs -= count;
            Debug.Log(noOfballs);
        }
    }
}