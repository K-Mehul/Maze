using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public GameObject panel;
    public GameObject pausePanel; 
    public GameObject winPanel;
    public Button retry;
    public Button pauseBtn;
    private void Awake() {
        if(instance == null) {
            instance = this;
        }

        panel.SetActive(false);
    }

    private void Start() {
       // panel = GameObject.FindGameObjectWithTag("MainMenu");
    }
    public void GamePause() {
        if(Time.timeScale == 1) {
            Time.timeScale = 0;
        }
        pausePanel.SetActive(true);
        retry.enabled = false;
    }

    public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        pausePanel.SetActive(false);
        retry.enabled = true;
        winPanel.SetActive(false);
    }

    public void Panel() {
        panel.SetActive(true);
        retry.enabled = false;
    }

    public void QuitApplication() {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void GamePlay() {
        pausePanel.SetActive(false);
        Time.timeScale = 1;
        retry.enabled = true;
    }

    public void MainMenu() {
        SceneManager.LoadScene("MainMenu");
    }
}