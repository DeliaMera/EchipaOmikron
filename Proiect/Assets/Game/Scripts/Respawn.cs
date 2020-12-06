using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
 
    void Update()
    {
        if(transform.position.y>=6)
        {
            SceneManager.LoadScene(11);
        }
        if (transform.position.y <=-6)
        {
            SceneManager.LoadScene(11);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(11);
    }
}
