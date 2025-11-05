using UnityEngine;

public abstract class Enemy : Character
{
    public int DamageHit {  get; protected set; }

    
    [SerializeField] private float contactDamage = 10f;

    private void OnCollisionEnter2D(Collision2D other)
    {
        var p = other.gameObject.GetComponent<Player>();
        if (p != null) p.TakeDamage(20);
    }


public abstract void Behavior();//method signature

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
