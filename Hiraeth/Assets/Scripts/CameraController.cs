using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CameraController : MonoBehaviour
{
   public GameObject player;
   Vector3 distance;
   public float turnspeed = 0.5f;
   private Vector3 offset;
   private Space offsetposition = Space.Self;
   void Start()
   {
       distance = this.transform.position - player.transform.position;
   }
 
   void Update()
   {
       if(offsetposition == Space.Self)
       {
           transform.position = player.transform.TransformPoint(distance);
       }
       else 
       {
           transform.position = player.transform.position + distance;
       }
          transform.rotation = player.transform.rotation;
   }
}