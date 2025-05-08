using UnityEngine;
using System.Collections.Generic;

public class Sword : MonoBehaviour
{
    private bool isPickedUp = false;
    private Dictionary<GameObject, int> enemyHealth = new Dictionary<GameObject, int>();

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Triggered with: " + other.gameObject.name);

        if (other.CompareTag("Player") && !isPickedUp)
        {
            PickupSword(other);
        }
        else if (isPickedUp && other.CompareTag("Enemy"))
        {
            if (!enemyHealth.ContainsKey(other.gameObject))
            {
                enemyHealth[other.gameObject] = 3;
            }

            enemyHealth[other.gameObject]--;
            Debug.Log($"Hit {other.gameObject.name}, Health Left: {enemyHealth[other.gameObject]}");

            if (enemyHealth[other.gameObject] <= 0)
            {
                Destroy(other.gameObject);
                enemyHealth.Remove(other.gameObject);
            }
        }
    }

    private void PickupSword(Collider2D playerCollider)
    {
        isPickedUp = true;
        Debug.Log("Sword picked up");

        transform.SetParent(playerCollider.transform);
        transform.localPosition = new Vector2(1, 0);

        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.linearVelocity = Vector2.zero;
        }
    }
}