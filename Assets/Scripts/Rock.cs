using UnityEngine;

public class Rock : Weapon
{
    public Rigidbody2D rb; 
    public Vector2 force;
    
    public override void Move()
    {
        rb.AddForce(force);
    }

    public override void OnHitWith(Character character)
    {
        throw new System.NotImplementedException();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
