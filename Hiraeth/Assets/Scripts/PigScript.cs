using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigScript : MonoBehaviour
{
    private Animation anim;
    public float speed = 1.0f;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        anim = this.gameObject.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        this.transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        //Debug.Log("Walking");
        anim.Play("Walk01");

        //Check if pig has reached target position 
        if(Vector3.Distance(transform.position, target.position) < 0.001f){
            //Swap the position of the target
            target.position *= -1.0f;
            //Rotate pig to turn around and walk the opposite direction
            //transform.rotation = new Vector3(transform.position.x, 0f, transform.position.y);
            transform.Rotate(transform.position.x, 0.0f, transform.position.z, Space.Self);

            //need to have pig turn around in opposite direction; both lines of code above did not work 
        }
    }
}
