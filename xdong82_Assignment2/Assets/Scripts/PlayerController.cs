using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    private Rigidbody rb;
    private int score;
    public Text scoreText;
    private ColourScores colours = new ColourScores();

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        score = 0;
        SetScoreText();
        colours.YellowScore = 1;
        colours.GreenScore = 2;
        colours.BlueScore = 5;
        colours.PurpleScore = 10;
    }


    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up Yellow"))
        {
            other.gameObject.SetActive(false);
            score += colours.YellowScore;
            SetScoreText();
        }
        if (other.gameObject.CompareTag("Pick Up Green"))
        {
            other.gameObject.SetActive(false);
            score += colours.GreenScore;
            SetScoreText();
        }
        if (other.gameObject.CompareTag("Pick Up Blue"))
        {
            other.gameObject.SetActive(false);
            score += colours.BlueScore;
            SetScoreText();
        }
        if (other.gameObject.CompareTag("Pick Up Purple"))
        {
            other.gameObject.SetActive(false);
            score += colours.PurpleScore;
            SetScoreText();
        }
    }

    void SetScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}

