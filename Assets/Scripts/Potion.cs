using UnityEngine;

public class Potion : MonoBehaviour
{
    public Transform holdPoint;
    private GameObject heldPotion;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && heldPotion == null)
        {
            Debug.Log("Potion picked up by player!");

            heldPotion = gameObject;

            Rigidbody2D rb = heldPotion.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.linearVelocity = Vector2.zero;
                rb.angularVelocity = 0f; 
                rb.bodyType = RigidbodyType2D.Kinematic;
            }

            heldPotion.transform.SetParent(holdPoint);
            heldPotion.transform.localPosition = Vector3.zero;

            if (heldPotion.GetComponent<PotionCollision>() == null)
            {
                heldPotion.AddComponent<PotionCollision>().SetActivated(false);
            }
        }
    }

    // Press T to throw the potion
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T) && heldPotion != null)
        {
            heldPotion.transform.SetParent(null);

            Rigidbody2D rb = heldPotion.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.bodyType = RigidbodyType2D.Dynamic; 

                Vector2 throwDir = transform.right;
                throwDir.Normalize();

                rb.linearVelocity = Vector2.zero;
                rb.AddForce(throwDir * 10f + Vector2.up * 2f, ForceMode2D.Impulse);
            }

            heldPotion.GetComponent<PotionCollision>().SetActivated(true);
            heldPotion = null;
        }
    }
}