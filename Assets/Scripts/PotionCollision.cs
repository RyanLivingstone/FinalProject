using UnityEngine;

public class PotionCollision : MonoBehaviour
{
    private bool activated = false;

    public void SetActivated(bool value)
    {
        activated = value;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!activated) return;

        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Enemy hit!");
            Destroy(collision.gameObject);
        }

        Destroy(gameObject);
    }
}
