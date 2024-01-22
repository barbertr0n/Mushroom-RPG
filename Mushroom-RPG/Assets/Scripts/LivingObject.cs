using UnityEngine;

// All living objects can be subject to these conditions.
public class LivingObject : MonoBehaviour
{
    public float MaxHealth = 100f;
    private float currentHealth;
    public float CurrentHealth
    {
        get { return currentHealth; }
        set
        {
            currentHealth = value;
            if (currentHealth > MaxHealth)
            {
                currentHealth = MaxHealth;
            }
            else if (currentHealth <= 0)
            {
                currentHealth = 0;
                Die();
            }
        }
    }

    public virtual void TakeDamage(float damage)
    {
        CurrentHealth -= damage;
        Debug.Log(CurrentHealth);
    }

    public virtual void Die()
    {
        Destroy(gameObject);
    }
}