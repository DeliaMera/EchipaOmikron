using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn2 : MonoBehaviour
{

    void Update()
    {
        if (transform.position.y >= 6)
        {
            SceneManager.LoadScene(15);
        }
        if (transform.position.y <= -6)
        {
            SceneManager.LoadScene(15);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(15);
    }
}
