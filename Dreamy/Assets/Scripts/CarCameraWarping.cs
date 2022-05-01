using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCameraWarping : MonoBehaviour
{
    public CarMovement carMovement;
    public Camera camera;


    // Start is called before the first frame update
    void Start()
    {
        carMovement = transform.parent.gameObject.GetComponent<CarMovement>();
        camera = GetComponent<Camera>();
        //t = (RigidBody)transform.parent.gameObject;
        
    }

    // Update is called once per frame
    void Update()
    {
        camera.fieldOfView = 60 + 30*(carMovement.racingPlaneMagnitude/carMovement.maxSpeed);
        
        
    }
}
