using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMain : MonoBehaviour
{
    public int Score;
    public Text score_text;
    private int Health = 100;
    public Text health_text;

    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
      //  UpdateScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        Respawn();
        //UpdateScoreText();
    }
    public void UpdateScoreText()
    {
        score_text.text = "Number of Goobers Saved: " + Score.ToString();
    }
    public void UpdateHealthText()
    {
        health_text.text = "Health: " + Health.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        //if (other.CompareTag("Fire"))
        //{
        //    Health -= 20;
        //    UpdateHealthText();
        //}
        if (other.CompareTag("Floor"))
        {
            Health -= 50;
            UpdateHealthText();
        }
        //if (other.CompareTag("Wall"))
        //{
        //    Health -= 5;
        //    UpdateHealthText();
        //}
    }
    private void Respawn()
    {
        Scene scene = SceneManager.GetActiveScene();
        if(Health == 0)
        {
            SceneManager.LoadScene(scene.buildIndex);
        }
    }

}
