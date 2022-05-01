using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarGenerator : MonoBehaviour
{
    public Star starRef;
    public float counter =0f;


    // Start is called before the first frame update
    void Start()
    {
        //this makes it so the first star is set as zero
        starRef.eep(0);
    }

    // Update is called once per frame
    void Update()
    {
        if(starRef.getStar() > 300)
        {
            Destroy(this);
            
        }


        counter += Time.deltaTime;
        if(counter > .15f)
        {
            Vector3 newPos = transform.position + Mathf.Cos(starRef.getStar()*17.5f)*transform.forward*50f + Mathf.Cos(starRef.getStar()*26.8f)*transform.right*50f;
            Instantiate(starRef,newPos,transform.rotation);
            counter = 0f;
        }
    }
}
