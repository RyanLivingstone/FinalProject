using UnityEngine;

public class PotionCollision : MonoBehaviour
{
    private bool activated = false;

    public void SetActivated(bool value)
    {
        activated = value;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            return;

        Debug.Log("Potion hit: " + collision.gameObject.name);

        if (!activated) return;

        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Enemy hit!");
            Destroy(collision.gameObject);
        }

        Destroy(gameObject);
    }
}

