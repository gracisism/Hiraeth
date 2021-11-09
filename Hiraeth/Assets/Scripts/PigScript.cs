using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigScript : MonoBehaviour
{
    private Animation anim;
    public float speed = 1.0f;
    public Transform target;
    public float range = 5f;
    public Transform player;
    private bool chasingPlayer = false;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = this.gameObject.GetComponent<Animation>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        float distance = Vector3.Distance(player.position, transform.position);
        print(distance);

        if (!chasingPlayer){
            //Pig walks up and down 
            this.transform.position = Vector3.MoveTowards(transform.position, target.position, step);
            anim.Play("Walk01");

            //Check if pig has reached target position 
            if(Vector3.Distance(transform.position, target.position) < 0.001f){
                transform.localRotation *= Quaternion.Euler(0, 180, 0);
                
                if(target.transform.position.x == 100){
                    target.transform.position = new Vector3(134, target.transform.position.y, target.transform.position.z);
                }
                else{
                    target.transform.position = new Vector3(100, target.transform.position.y, target.transform.position.z);
                }
            }
        }
        else{
            //Check if player is within enemy distance 
            if(distance <= range){
                chasingPlayer = true;
                transform.position = Vector3.MoveTowards(transform.position, target.position, step);
            }
            else{
                chasingPlayer = false;
            }
        }
        //     n   n
        //   ((.)_(.))
        //   <(     )>
        //     v   v
        //    -------
        

    
        
        
        
    }
}
