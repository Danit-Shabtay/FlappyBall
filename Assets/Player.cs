using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpPower = 5;
    public int score = 0;
    public TextMeshProUGUI scoreText;

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
            score++;
            scoreText.text = score.ToString();
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Obs")
        Application.LoadLevel(Application.loadedLevel);
    }
}
