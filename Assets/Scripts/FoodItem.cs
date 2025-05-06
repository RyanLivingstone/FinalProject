using UnityEngine;

public class FoodItem : MonoBehaviour
{
    public int healthValue = 3;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Health health = other.GetComponent<Health>();
            if (health != null)
            {
                health.RestoreHealth(healthValue);
                Destroy(gameObject);
            }
        }
    }
}