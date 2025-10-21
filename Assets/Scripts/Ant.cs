using UnityEditor.Tilemaps;
using UnityEngine;

using UnityEngine;

public class Ant : Enemy
{
    [SerializeField] Vector2 velocity;
    public Transform[] MovePoint;

    void Start()
    {
        base.Intialize(20);
        DamageHit = 20;
        velocity = new Vector2(-1.0f, 0.0f);
    }

    public override void Behavior()
    {
        // ใช้ Rigidbody2D และ Vector2 ให้ครบ
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);

        if (velocity.x < 0 && rb.position.x <= MovePoint[0].position.x)
        {
            Flip();
        }

        if (velocity.x > 0 && rb.position.x >= MovePoint[1].position.x)
        {
            Flip();
        }
    }

    private void FixedUpdate()
    {
        Behavior();
    }

    public void Flip()
    {
        velocity.x *= -1;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    void Update() { }
}
