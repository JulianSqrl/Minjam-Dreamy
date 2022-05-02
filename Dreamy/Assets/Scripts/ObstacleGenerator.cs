using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    int count = 0;
    // Start is called before the first frame update
    public Rigidbody objectRef;
    public float counter =0f;


    // Start is called before the first frame update
    void Start()
    {
        //this makes it so the first star is set as zero
        
    }

    // Update is called once per frame
    void Update()
    {
        if(counter > 110)
        {
            Destroy(this);
        }


        counter += Time.deltaTime;
        if(counter > .5f)
        {
            count += 1;
        
            Vector3 newPos = transform.position + Mathf.Cos(count*145.3f)*transform.forward*50f + Mathf.Cos(count*236.1f)*transform.right*50f;

            Rigidbody newObject = Instantiate<Rigidbody>(objectRef,newPos,transform.rotation);
            
            newObject.angularVelocity = new Vector3(3f*Mathf.Cos(count),3f*Mathf.Cos(count),3f*Mathf.Cos(count));
            newObject.AddForce(new Vector3(0f,10000f,0f));
            counter = 0f;
        }
    }
}
