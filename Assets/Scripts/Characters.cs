using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Characters : IDamageable,IHealable
{
    [SerializeField] private CharacterData CharacterStats;

    public virtual void Heal(float healTake)
    {
        
    }

    public virtual void TakeDamage(float damageTaken)
    {
       
    }

    public virtual void Shot()
    {

    }

    public virtual void OnEnter()
    {

    }

    public virtual void OnUpdate()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        OnEnter();
    }

    // Update is called once per frame
    void Update()
    {
        OnUpdate();
    }
}
