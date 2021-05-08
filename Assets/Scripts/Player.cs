using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpPower = 5;
    public int score = 0;
    public TextMeshProUGUI scoreText;
    public GameObject gameOverPanel;
    public Text endScoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            rb.velocity += Vector3.up * jumpPower;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "AddScore")
        {
            score+=50;
            scoreText.text = score.ToString();
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obs")
            EndGame();
        //Application.LoadLevel(Application.loadedLevel);
    }

    void EndGame()
    {
        Time.timeScale = 0;
        endScoreText.text = "Your Score:" + score;
        gameOverPanel.SetActive(true);
    }

    public void PlayAgain() {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
