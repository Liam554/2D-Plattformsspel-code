using UnityEngine;
using UnityEngine.SceneManagement;
public class CharacterStats : MonoBehaviour
{
    public Stat strenght;
    public Stat damage;
    public Stat maxHealth;

    public int currentHealth;

    public System.Action onHealthChanged;

    protected virtual void Start()
    {
        
        currentHealth = GetMaxHealthValue();

        Debug.Log("Character stats called");

        if (onHealthChanged != null)
        {
            onHealthChanged();
        }
    }

    public virtual void DoDamage(CharacterStats _targetStats)
    {


        int totalDamage = damage.GetValue() + strenght.GetValue();

        _targetStats.TakeDamge(totalDamage);
    }

    public virtual void TakeDamge(int _damage)
    {
        DecreaseHealthBy(_damage);

        Debug.Log(_damage);

        if (currentHealth < 0)
        {
            Die();
        }

    }

    protected virtual void DecreaseHealthBy(int _damage)
    {
        currentHealth -= _damage;

        if (onHealthChanged != null)
        {
            onHealthChanged();
        }
    }


    protected virtual void Die()
    {
    }

    public int GetMaxHealthValue()
    {
        return maxHealth.GetValue();
    }
}
