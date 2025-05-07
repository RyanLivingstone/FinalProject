using UnityEngine;

public class Potion : MonoBehaviour
{
    public Transform holdPoint;
    private GameObject heldPotion;

    void Update()
    {
        // Press P to pick up
        if (Input.GetKeyDown(KeyCode.P) && heldPotion == null)
        {
            Collider[] hits = Physics.OverlapSphere(transform.position, 2f);
            foreach (Collider hit in hits)
            {
                if (hit.CompareTag("Potion"))
                {       
                    heldPotion = hit.gameObject;

                    Rigidbody rb = heldPotion.GetComponent<Rigidbody>();
                    if (rb != null)
                    {
                        rb.linearVelocity = Vector3.zero;
                        rb.angularVelocity = Vector3.zero;
                        rb.useGravity = false;
                        rb.isKinematic = true;
                    }

                    heldPotion.transform.SetParent(holdPoint);
                    heldPotion.transform.localPosition = Vector3.zero;

                    if (heldPotion.GetComponent<PotionCollision>() == null)
                    {
                        heldPotion.AddComponent<PotionCollision>().SetActivated(false);
                    }
                    break;
                }
            }
        }

        // Press T to throw
        if (Input.GetKeyDown(KeyCode.T) && heldPotion != null)
        {
            heldPotion.transform.SetParent(null);

            Rigidbody rb = heldPotion.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.isKinematic = false;
                rb.useGravity = true;
                rb.collisionDetectionMode = CollisionDetectionMode.Continuous;

                Vector3 throwDir = transform.forward;
                throwDir.y = 0;
                throwDir.Normalize();

                rb.linearVelocity = Vector3.zero;
                rb.AddForce(throwDir * 10f + Vector3.up * 2f, ForceMode.Impulse);
            }

            heldPotion.GetComponent<PotionCollision>().SetActivated(true);
            heldPotion = null;
        }
    }
}
