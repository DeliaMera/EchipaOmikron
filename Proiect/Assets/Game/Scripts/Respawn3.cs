using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn3 : MonoBehaviour
{

    void Update()
    {
        if (transform.position.y >= 6)
        {
            SceneManager.LoadScene(18);
        }
        if (transform.position.y <= -6)
        {
            SceneManager.LoadScene(18);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(18);
    }
}
