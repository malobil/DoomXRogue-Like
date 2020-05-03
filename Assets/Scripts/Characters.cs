using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Characters : MonoBehaviour,IDamageable,IHealable
{
    [Header("Data")]
    [SerializeField] protected CharacterData CharacterStats;
    protected CurrentCharacterStats currentStats = new CurrentCharacterStats() ;
    protected float shotCD = 0 ;
    protected bool canShot = true;
    private bool canMove = true;

    [Header("Camera")]
    [SerializeField] protected Transform CharacterCamera ;
    [SerializeField] private float CameraSensitivity = 0.5f ;
    private float xCameraRotation;

    [Header("Jump")]
    private int CurrentJumpNum;

    [Header("Shot")]
    [SerializeField] protected GameObject BulletPrefab ;

    [Header("Spells")]
    [SerializeField] private Spell pasivSpell;
    [SerializeField] private Spell activSpell;
    [SerializeField] private Spell ultimateSpell;

    [Header("Weapon")]
    [SerializeField] private Weapon currentWeapon;

    //Controls
    private CharacterControls ActionControls;
    private Vector2 MovementInputs;

    //Components
    private Rigidbody RbComponent;


    public virtual void OnEnter()
    {
        SetupStats();
        SetupWeapon();
        SetupSpell();
        SetupUltimate();
        ActionControls = new CharacterControls();
        ActionControls.CharacterMoves.Jump.performed += ctx => Jump();
        ActionControls.CharacterMoves.Shot.performed += ctx => Shot();
        ActionControls.CharacterMoves.Spell.performed += ctx => CastSpell();
        ActionControls.CharacterMoves.Ultimate.performed += ctx => CastUltimate();
        ActionControls.Enable();
        RbComponent = GetComponent<Rigidbody>();
    }

    public virtual void OnUpdate()
    {
        Move();
        CameraControl();
        ReloadShot();
    }

    public virtual void SetupStats()
    {
        currentStats.CurrentAtkSpeed = CharacterStats.AtkSpeed;
        currentStats.CurrentCDR = CharacterStats.CDR;
        currentStats.CurrentDamage = CharacterStats.Damage;
        currentStats.CurrentHP = CharacterStats.HP;
        currentStats.CurrentHPRegain = CharacterStats.HPRegain;
        currentStats.CurrentJumpForce = CharacterStats.JumpForce;
        currentStats.CurrentJumpNumber = CharacterStats.JumpNumber;
        currentStats.CurrentMoveSpeed = CharacterStats.MoveSpeed;
        currentStats.CurrentRange = CharacterStats.Range;
        currentStats.CurrentReloadSpeed = CharacterStats.ReloadSpeed;
        currentStats.CurrentShield = CharacterStats.Shield;
        currentStats.CurrentSpellDamage = CharacterStats.SpellDamage;
    }

    public virtual void SetupWeapon()
    {
        currentWeapon.Setup(this);
    }

    public virtual void SetupSpell()
    {
        if(activSpell != null)
        activSpell.Setup(this);
    }

    public virtual void SetupUltimate()
    {
        if(ultimateSpell != null)
        ultimateSpell.Setup(this);
    }

    public virtual void Heal(float healTake)
    {
        
    }

    public virtual void TakeDamage(float damageTaken)
    {
       
    }

    public virtual void Shot()
    {
        Debug.Log(canShot);
        if (!canShot)
        {
            return;
        }

        currentWeapon.Shot();

        canShot = false;
        shotCD = 0;
       
    }

    public virtual void CastSpell()
    {
        if(activSpell != null)
        activSpell.Preview();
    }

    public virtual void CastUltimate()
    {
        if(ultimateSpell != null)
        ultimateSpell.Preview();
    }

    public virtual void ReloadShot()
    {
        if(!canShot)
        {
            if (shotCD < currentStats.CurrentReloadSpeed)
            {
                shotCD += Time.deltaTime;
            }
            else
            {
                canShot = true;
            }
        }
    }


    public virtual void Move()
    {
        if(!canMove)
        {
            return;
        }

        MovementInputs = ActionControls.CharacterMoves.Movements.ReadValue<Vector2>();
        Vector3 Movement = (transform.forward.normalized * MovementInputs.y * currentStats.CurrentMoveSpeed) + (transform.right * MovementInputs.x * currentStats.CurrentMoveSpeed);
        Movement.y = RbComponent.velocity.y;
        RbComponent.velocity = Movement;
    }

    public virtual void CameraControl()
    {
        float mouseX = ActionControls.CharacterMoves.MousePosition.ReadValue<Vector2>().x * CameraSensitivity * Time.deltaTime;
        float mouseY = ActionControls.CharacterMoves.MousePosition.ReadValue<Vector2>().y * CameraSensitivity * Time.deltaTime;
        transform.Rotate(Vector3.up * mouseX);

        xCameraRotation -= mouseY;
        xCameraRotation = Mathf.Clamp(xCameraRotation, -90f, 90f);

        CharacterCamera.localRotation = Quaternion.Euler(xCameraRotation, CharacterCamera.localRotation.y, CharacterCamera.localRotation.z);
    }

    public virtual void Jump()
    {
        if(CurrentJumpNum > 0)
        {
            RbComponent.AddForce(Vector3.up * currentStats.CurrentJumpForce, ForceMode.Impulse);
            CurrentJumpNum--;
        }
    }

    public virtual void ResetJump()
    {
        CurrentJumpNum = currentStats.CurrentJumpNumber;
    }

    public CurrentCharacterStats GetCurrentStats()
    {
        return currentStats;
    }

    public Transform GetCamera()
    {
        return CharacterCamera;
    }

    public Vector3 GetMovementInputs()
    {
        return MovementInputs;
    }

    public void DisableMovement()
    {
        canMove = false;
    }

    public void AllowMovement()
    {
        canMove = true;
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

public class CurrentCharacterStats
{
    public float CurrentHP;
    public float CurrentHPRegain;
    public float CurrentShield;
    public float CurrentDamage;
    public float CurrentSpellDamage;
    public float CurrentRange;
    public float CurrentCDR;
    public float CurrentAtkSpeed;
    public float CurrentReloadSpeed;
    public float CurrentMoveSpeed;
    public int CurrentJumpNumber;
    public float CurrentJumpForce;
}
