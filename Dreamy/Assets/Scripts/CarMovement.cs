using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float turnMagnitude = 0f;
    public float forwardMagnitude = 1f;

    public float maxSpeed = 70f;
    public float backwardsMaxSpeed = 20f;
    public float acceleration = 5000f;
    public bool Controllable=false;
    public Vector3 defaultCOM = new Vector3(0f,-.1f,-0.4f);


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();

        //this changes how the car reacts to roads and speed
        rigidbody.centerOfMass = defaultCOM;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Controllable)
        {
            turnMagnitude = Input.GetAxisRaw("Horizontal");
            forwardMagnitude = Input.GetAxisRaw("Vertical");
        }

        DriveCar(); 
    }

    public void DriveCar()
    {
        if(IsNotColliding)
        {
            return;
        }


        
        //generalised version of getting two perp vectors on a 2D plane, does not take y into account as thats gravity therefore
        //gravity works like normal when in the air
        Vector2 racingPlane = new Vector2((transform.forward.x*rigidbody.velocity.x+transform.forward.z*rigidbody.velocity.z),
        (transform.right.x*rigidbody.velocity.x+transform.right.z*rigidbody.velocity.z));
        
        if (racingPlane.magnitude>maxSpeed)
        {
            rigidbody.drag =1f+ racingPlane.magnitude-maxSpeed;
        }
        else if((forwardMagnitude<0 && racingPlane.magnitude>backwardsMaxSpeed))
        {
            rigidbody.drag =1f+ racingPlane.magnitude-backwardsMaxSpeed;

        }
        else
        {
            rigidbody.drag = 0.1f;
        }


        rigidbody.AddForce(transform.forward*forwardMagnitude*Time.deltaTime*acceleration);
        rigidbody.angularVelocity = new Vector3(0f,1f,0f) *turnMagnitude * 1.5f*(0.3f+(rigidbody.velocity.magnitude/maxSpeed));
    }
 
    


    //this is so that the car knows when to drive
     private int collisionCount = 0;
 
     public bool IsNotColliding
     {
         get { return collisionCount == 0; }
     }
 
     void OnCollisionEnter(Collision col)
     {
         collisionCount++;
     }
 
     void OnCollisionExit(Collision col)
     {
         collisionCount--;
     }



}
