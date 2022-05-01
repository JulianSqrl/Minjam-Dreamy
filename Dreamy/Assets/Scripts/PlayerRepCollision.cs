using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRepCollision : MonoBehaviour
{
    float counter = 0f;

    void Update()
    {
        counter += Time.deltaTime;
        if (counter >= 60)
        {
            SceneManager.LoadScene(3);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(3);


    }
}
