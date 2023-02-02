using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltController : MonoBehaviour
{
    public GameObject canvasUI;
    public GameOverControl control;
    public GameObject Audio;
    public Innersitial ad;

    Rigidbody rb;
    float dx;
    float dz;
    float movementSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Audio = GameObject.FindGameObjectWithTag("Audio");
    }

    // Update is called once per frame
    void Update()
    {
        dx = Input.acceleration.x * movementSpeed;
        dz = Input.acceleration.y * movementSpeed;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -7.5f, 7.5f), transform.position.y, Mathf.Clamp(transform.position.z, -7.5f, 7.5f));

    }

    private void FixedUpdate() {
        rb.velocity = new Vector3(dx,0f,0f);
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag=="car"){
            canvasUI.SetActive(true);
            ad.GameOver();
        }
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag=="Coins"){
            control.addScore();
            Audio.GetComponent<AudioManager>().PlayCoin();
        }
    }
}
