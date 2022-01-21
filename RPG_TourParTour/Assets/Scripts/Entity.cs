using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    [SerializeField] protected string name;
    [SerializeField] protected int health;
    [SerializeField] protected int maxHealth;

    public abstract void OnHit(int dmg);

    public abstract void OnDeath();

    public void AddHP(int _health)
    {
        health += _health;
    }

    public void LooseHP(int _health)
    {
        health -= _health;
    }
}
