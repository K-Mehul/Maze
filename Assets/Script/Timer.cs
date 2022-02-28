using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{   public  static Timer instance;
    public Image timerImage;
    [SerializeField]public GameObject timesUpText;
    public float timeLeft;
    int maxTime = 50 ;
    private void Awake() {
        if(instance == null) {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        timerImage = GetComponent<Image>();
        timesUpText.SetActive(false);
        timeLeft = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(timeLeft > 0) {
            timeLeft -= Time.deltaTime;
            timerImage.fillAmount = timeLeft/maxTime;
        }  else {
            timesUpText.SetActive(true);
            Time.timeScale = 0;
            UIManager.instance.Panel();
        }       
    }
}
