using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HosppitalStaging : MonoBehaviour
{
    public GameObject Vesta;
    bool vestaSpawned = false;
    float Count = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Count += Time.deltaTime;
        if(Count >12f && vestaSpawned == false)
        {
            Instantiate(Vesta,new Vector3(350f,12.5f,-63f),new Quaternion(-1f,0f,0f,1f));
            vestaSpawned = true;

        }

        if(Count >= 24f)
        {
            SceneManager.LoadScene(4);

        }
        
    }
}
