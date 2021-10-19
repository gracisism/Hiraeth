using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordScript : MonoBehaviour
{
    public float speed = 2f;
    public float maxRotation = 45f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(maxRotation * Mathf.Sin(Time.time * speed), 0f, 0f);
    }
    void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player")){
            Destroy(other);
        }
    }
}
