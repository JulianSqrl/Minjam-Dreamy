using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    public static int ID;
    public float count = 0f;

    Vector3 spawnLocation;
    Quaternion spawnRotation;
    // Start is called before the first frame update

    //this should only be called once
    public int getStar()
    {
        return ID;
    }
    public void eep(int v)
    {
        ID = v;

    }

    void Start()
    {
        ID+=1;
        spawnLocation = transform.position;
        spawnRotation = transform.rotation;
        Reset();
        
    }

    void Reset()
    {
        transform.position = spawnLocation;
        transform.rotation = spawnRotation;
        count = 0f;
        transform.Rotate(new Vector3(3.37f*Mathf.Sin(817*ID),0f,0f));
        transform.Rotate(new Vector3(0f,0f,6.2f*Mathf.Sin(113*ID)));
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up*Time.deltaTime*140f;

        count += Time.deltaTime;
        if(count >= 4f && this != null)
        {
            Reset();
        }

        
    }
}
