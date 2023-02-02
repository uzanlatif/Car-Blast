using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject[] Cam;
    int counter;

    private void Awake() {
        Screen.orientation = ScreenOrientation.LandscapeLeft;  
    }

    private void Start() {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        counter=3000;
        SelectedCar();
    }

    public void Next(){
        counter++;
        for(int i = 0; i < Cam.Length; i++){
            Cam[i].SetActive(false);
            
        }
        Cam[counter%3].SetActive(true);

        SelectedCar();
    }

    public void Previous(){
        counter--;
        for(int i = 0; i < Cam.Length; i++){
            Cam[i].SetActive(false);
            
        }
        Cam[counter%3].SetActive(true);

        SelectedCar();
    }

    public void SelectedCar(){
        if(counter%3==0){
            PlayerPrefs.SetString("Cars", "MonsterCar");
        }
        if(counter%3==1){
            PlayerPrefs.SetString("Cars", "SharkCar");
        }
        if(counter%3==2){
            PlayerPrefs.SetString("Cars", "CityCar");
        }
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
