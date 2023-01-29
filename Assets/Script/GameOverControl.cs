using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class GameOverControl : MonoBehaviour
{
    public GameObject audio;
    public int score;
    public TMPro.TextMeshProUGUI tmpScore;
    
    public void Awake(){
        score = 0;
    }

    public void Retry(){
        SceneManager.LoadScene("SampleScene");
    }

    public void MainMenu(){
        SceneManager.LoadScene("MainMenu");
    }

    public void addScore(){
        score++;
        tmpScore.text = score.ToString();
    }

    public void playBtn(){
        GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>().PlayButton();
    }

}
