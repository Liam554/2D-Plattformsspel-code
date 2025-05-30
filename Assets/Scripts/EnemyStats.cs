using UnityEngine;

public class EnemyStats : CharacterStats
{
    private Enemy enemy;

    protected override void Start()
    {
        base.Start();

        enemy = GetComponent<Enemy>();
    }

    public override void TakeDamge(int _damage)
    {
        base.TakeDamge(_damage);

        enemy.DamageEffect();
    }

    protected override void Die()
    {
        base.Die();
        enemy.Die();
    }
}
