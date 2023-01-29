using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public string MyCar;
    public GameObject[] cars;
    private void Awake() {
        MyCar = PlayerPrefs.GetString("Cars");

        if(MyCar == "MonsterCar"){
            cars[0].SetActive(true);
        }
        if(MyCar == "SharkCar"){
            cars[1].SetActive(true);
        }
        if(MyCar == "CityCar"){
            cars[2].SetActive(true);
        }
    }
}
