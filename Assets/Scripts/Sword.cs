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

    public Transform swordHoldPoint;

    private void PickupSword(Collider2D playerCollider)
    {
        isPickedUp = true;

        transform.SetParent(swordHoldPoint); 
        transform.localPosition = Vector3.zero;

        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.bodyType = RigidbodyType2D.Kinematic;
        }
    }
}