using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCheckpointLoader : MonoBehaviour
{
    public Vector3 LastCheckpoint  ;
    public Quaternion LastCheckpointRotation;

    void Start()
    {
        //default pos
        LastCheckpoint  = transform.position;
        LastCheckpointRotation = transform.rotation;
    }

    public void LoadCheckpoint()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0f,0f,0f);
        GetComponent<Rigidbody>().angularVelocity = new Vector3(0f,0f,0f);

        transform.position = LastCheckpoint ;
        transform.rotation = LastCheckpointRotation;


    }


    void Update()
    {
        if(transform.position.y < -100f)
        {
            LoadCheckpoint();

        }
    }
}
