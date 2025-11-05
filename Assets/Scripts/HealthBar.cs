using UnityEngine;
using UnityEngine.UI;

public class HealthBar : Character
{
    public int MaxHealth = 100;
    public int CurHealth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CurHealth = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.K))
        {
            TakeDamage(20);
        }
    }





}

