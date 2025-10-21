using UnityEngine;

public class Player : Character
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Intialize(100);
    }

    public void OnHitWith(Enemy enemy)
    {
        TakeDamage(enemy.DamageHit);
    }

    private void OnCollisionEnter2D(Collision2D Other)
    {
       Enemy enemy = Other.gameObject.GetComponent<Enemy>();
        if (enemy != null)
        {
            OnHitWith(enemy);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
