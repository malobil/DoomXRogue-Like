using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spell : MonoBehaviour
{
    [SerializeField] private bool m_IsInstant = true;
    [SerializeField] private float m_Cooldown = 3f;
    private float currentCooldown = 0f;
    private bool isInCD = false;
    protected Characters associateCharacter;

    public virtual void OnEnter()
    {

    }

    public virtual void OnUpdate()
    {
        if(isInCD)
        {
            currentCooldown -= Time.deltaTime;
            UIManager.Singleton.UpdateActivSpellCD(currentCooldown);

            if(currentCooldown <= 0)
            {
                isInCD = false;
            }
        }
    }

    public void Setup(Characters newCharacter)
    {
        associateCharacter = newCharacter;
    }

    public virtual void Preview()
    {
        if(m_IsInstant && !isInCD)
        {
            Cast();
        }
    }
    
    public virtual void Cast()
    {
        isInCD = true;
        currentCooldown = m_Cooldown;
        //Do spell action here
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
