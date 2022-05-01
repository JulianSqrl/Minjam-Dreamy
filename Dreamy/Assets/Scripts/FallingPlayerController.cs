using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlayerController : MonoBehaviour
{
    public GameObject playerRep;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 InputValues = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));


        Quaternion finalRot = new Quaternion(0f,0f,0f,1f);

        finalRot.x = 0.2f*InputValues.y;
        finalRot.z = -0.2f*InputValues.x;

        playerRep.transform.rotation = finalRot;




        transform.position += (transform.right*InputValues.x +transform.forward*InputValues.y).normalized*Time.deltaTime*100f;



        
    }
}
