using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandoDash : Spell
{
    [SerializeField] private float dashTime;
    [SerializeField] private float dashSpeed;
    [SerializeField] private float damageBonus;

    private bool isDashing = false;
    private float currentDashTime = 0f;
    private Rigidbody characterRb;

    public override void OnEnter()
    {
        characterRb = associateCharacter.GetComponent<Rigidbody>();
    }

    public override void OnUpdate()
    {
        base.OnUpdate();

        if(isDashing)
        {
            currentDashTime += Time.deltaTime;

            if(currentDashTime >= dashTime)
            {
                isDashing = false;
                associateCharacter.AllowMovement();
                characterRb.useGravity = true;
            }
        }
    }

    public override void Cast()
    {
        associateCharacter.DisableMovement();
        characterRb.velocity = Vector3.zero;
        Vector3 currentVelocity = new Vector3(associateCharacter.GetMovementInputs().x,0, associateCharacter.GetMovementInputs().y);
        currentVelocity = (transform.forward.normalized * currentVelocity.z) + (transform.right.normalized * currentVelocity.x);

        if (currentVelocity == Vector3.zero)
        {
            currentVelocity = associateCharacter.transform.forward;
        }

        characterRb.useGravity = false;

        characterRb.velocity = (currentVelocity * dashSpeed);
        isDashing = true;
        currentDashTime = 0;
        base.Cast();
    }
}
