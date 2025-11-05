using UnityEngine;

public class crocodie : Enemy , IShootable
{
    [SerializeField] float atkRange;
    public Player player;

    [field:SerializeField] public GameObject Bullet { get; set; }
    [field: SerializeField] public Transform ShootPoint { get; set; }
    public float ReloadTime { get; set; }
    public float WaitTime { get; set; }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Intialize(200);
        DamageHit = 30;
        atkRange = 6.0f;
        player = GameObject.FindFirstObjectByType<Player>();

        WaitTime = 0.0f;
        ReloadTime = 5.0f;

    }

    public override void Behavior()
    {
        Vector2 distance = transform.position - player.transform.position;
        if (distance.magnitude <= atkRange)
        {
            Debug.Log($"{player.name} is in the {this.name}'s atk range!");
            Shoot();
        }
    }
    public void Shoot()
    {
        if (WaitTime >= ReloadTime)
        {
            anim.SetTrigger("Shoot");
            var bullet = Instantiate(Bullet, ShootPoint.position, Quaternion.identity);
            Rock rock = bullet.GetComponent<Rock>();
            rock.InitWeapon(30, this);
            WaitTime = 0;
            Debug.Log($"{this.name} shoots rock to the {player.name}!");
        }
    }

    private void FixedUpdate()
    {
        WaitTime += Time.fixedDeltaTime; //timer
        Behavior();
    }

    // Update is called once per frame
    void Update()
    {
        Behavior();
    }
}