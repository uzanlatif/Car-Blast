using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarNpc : MonoBehaviour
{
    public float moveSpeed;
    // Start is called before the first frame update

    private void FixedUpdate() {
        transform.position += new Vector3(0, 0, -moveSpeed);
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag=="ClearNPC"){
            Destroy(gameObject);
        }
    }
}
