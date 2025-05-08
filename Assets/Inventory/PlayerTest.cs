using UnityEngine;

public class PlayerTest : MonoBehaviour
{
    public float speed;
    private Animator animator;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         Vector2 dir = Vector2.zero;
            if (Input.GetKey(KeyCode.A))
            {
                dir.x = -1;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                dir.x = 1;
            }

            if (Input.GetKey(KeyCode.W))
            {
                dir.y = 1;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                dir.y = -1;
            }

            dir.Normalize();

            GetComponent<Rigidbody2D>().linearVelocity = speed * dir;
    }
}
