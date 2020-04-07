using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Characters : MonoBehaviour,IDamageable,IHealable
{
    [SerializeField] private CharacterData CharacterStats;

    private CharacterControls ActionControls;

    private Vector2 MovementInputs;
    private Rigidbody RbComponent;

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
        ActionControls = new CharacterControls();
        ActionControls.Enable();
        RbComponent = GetComponent<Rigidbody>();
    }

    public virtual void OnUpdate()
    {
        Move();
    }

    public virtual void Move()
    {
        MovementInputs = ActionControls.Move.Movements.ReadValue<Vector2>();
        Vector3 Movement = (transform.forward.normalized * MovementInputs.y * CharacterStats.MoveSpeed) + (transform.right * MovementInputs.x * CharacterStats.MoveSpeed);
        Movement.y = RbComponent.velocity.y;
        RbComponent.velocity = Movement;
    }

    // Start is called before the first frame update
    void Awake()
    {
        OnEnter();
    }

    // Update is called once per frame
    void Update()
    {
        OnUpdate();
    }
}
