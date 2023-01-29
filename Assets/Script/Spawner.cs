using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] car;
    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("SpawnCar",1f,0.5f); 
    }


    void SpawnCar(){
        Debug.Log("Spawn");

        var position = new Vector3(Random.Range(-4.603f, 3.37f),0.385f, transform.position.z);

        var rand = Random.Range(0,5);
        Instantiate(car[rand],position, Quaternion.Euler(new Vector3(0, 180, 0)));
    }
}
