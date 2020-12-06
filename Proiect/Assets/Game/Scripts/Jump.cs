using UnityEngine;

public class Jump : MonoBehaviour
{
    public Vector2 Force;
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GetComponent<Rigidbody2D>().AddForce(Force);
        }
    }
}
