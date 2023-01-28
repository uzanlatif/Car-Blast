using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public void Next(){

    }

    public void Previous(){

    }

    public void Play(){
        SceneManager.LoadScene("SampleScene");
    }

    public void Setting(){

    }

    public void Quit(){
        Application.Quit();
    }
}
