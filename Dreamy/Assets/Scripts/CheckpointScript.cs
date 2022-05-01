using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointScript : MonoBehaviour
{

    private Vector3 checkpointPosition;
    private Quaternion checkpointRotation;


    // Start is called before the first frame update
    void Start()
    {
        checkpointPosition = transform.position;
        checkpointRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponentInParent<CarCheckpointLoader>() == null)
        {
            
            return;
        }

        other.GetComponentInParent<CarCheckpointLoader>().LastCheckpoint = checkpointPosition;
        other.GetComponentInParent<CarCheckpointLoader>().LastCheckpointRotation = checkpointRotation;

        Destroy(this);


    }
}
