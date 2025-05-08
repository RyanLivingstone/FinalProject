using UnityEngine;

public class Sword : MonoBehaviour
{
    public GameObject player;
    private bool isPickedUp = false;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player") && !isPickedUp)
        {
            PickupSword(collider);
        }
    }

    public Transform holdPoint;

    private void PickupSword(Collider2D playerCollider)
    {
        isPickedUp = true;

        transform.SetParent(holdPoint); 
        transform.localPosition = new Vector2(1, 0);

        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.bodyType = RigidbodyType2D.Kinematic;
        }
    }
}