using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    int nextSceneIndex = 1;
    public void PlayGame() {
        SceneManager.LoadScene(nextSceneIndex,LoadSceneMode.Single);        
    }
}
