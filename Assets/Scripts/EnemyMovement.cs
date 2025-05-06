using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Transform target;
    public float speed;
    public float detectionRange = 10f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
    // Finds distance between the enemy and player and if that distance is shorter than the detectionRange it will follow through with the enemy's movement
        float distanceFromPlayer =  Vector2.Distance(transform.position, target.position);

        if (distanceFromPlayer <= detectionRange){
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
}
