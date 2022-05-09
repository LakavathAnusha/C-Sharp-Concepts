using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public int speed;
    public int health;
    public abstract void Attack();
    public virtual void Die()
    {
        Debug.Log("Iam dead");
    }
   
   
}
public class Robot:Enemy // which needs to enemy
{
    public override void Attack()
    {
        
    }
    public override void Die()
    {
        base.Die();
    }
}
