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
    protected Rigidbody2D rb;

    //initialize variable
    public void Intialize(int StarHealth)
    {
        Health = StarHealth;
        Debug.Log($"{this.name} is initializd Halth : {this.Health}");

        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }


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
