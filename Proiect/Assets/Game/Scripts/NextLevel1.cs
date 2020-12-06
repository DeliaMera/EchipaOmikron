using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel1 : MonoBehaviour
{

    void Update()
    {
        if (transform.position.x <= -10)
        {
            SceneManager.LoadScene(14);
        }
    }
}
