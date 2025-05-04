using UnityEngine;
using System.Collections.Generic;

public class Sword : MonoBehaviour
{
    private bool isPickedUp = false;
    private Dictionary<GameObject, int> enemyHealth = new Dictionary<GameObject, int>();

    private void OnTriggerEnter(Collider other)
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
            
            Debug.Log($"Hit{other.gameObject.name}, Health Left: {enemyHealth[other.gameObject]}");

            if (enemyHealth[other.gameObject] <=0)
            {
                Destroy(other.gameObject);
                enemyHealth.Remove(other.gameObject);
            }
        }
    }

    private void PickupSword(Collider playerCollider)
    {
        isPickedUp = true;
        Debug.Log("Sword picked up");

        transform.SetParent(playerCollider.transform);
        transform.localPosition = new Vector3(1, 0, 0);
        
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.isKinematic = true;
            rb.useGravity = false;
        }
    }
}
