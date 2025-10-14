using UnityEngine;

public class Character : MonoBehaviour
{
    // attributes
    private int health;

    public int Health
    {
        get {return health;}
        set { health = (value < 0) ? 0 : value; }
    }

    protected Animator anim;
    protected Rigidbody rb;

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Debug.Log($"{this.name} took damage {damage} Current Health {Health}");
    }


    public bool IsDead()
    {
        if (Health <= 0)
        {
            Destroy(this.gameObject);
            return true;
        }
        else
        {
            return false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
