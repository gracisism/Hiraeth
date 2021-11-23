using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StumpScript : MonoBehaviour
{
    public float xPos;
    public int length = 2;

    // Start is called before the first frame update
    void Start()
    {
        xPos = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(xPos + Mathf.PingPong(Time.time, length), transform.position.y, transform.position.z);
    }
}
