using UnityEngine;

public class Movement : MonoBehaviour
{   
    public static Movement instance;
    Rigidbody2D rb;
    float dirX,dirY;
    public int speed ;
    // Start is called before the first frame update
    void Start()
    {
        if(instance == null) {
            instance = this;
        }

        rb = GetComponent<Rigidbody2D>();
        Time.timeScale = 1;
        UIManager.instance.panel.SetActive(false);
        UIManager.instance.pausePanel.SetActive(false);
        UIManager.instance.winPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       // dirX = Input.acceleration.x * speed * Time.deltaTime;
       // dirY = Input.acceleration.y *speed * Time.deltaTime;

        dirX = Input.GetAxis("Horizontal") *speed * Time.deltaTime;
        dirY = Input.GetAxis("Vertical") * speed * Time.deltaTime;
    }

    private void FixedUpdate() {
        rb.velocity = new Vector2(dirX,dirY);
    }
}
