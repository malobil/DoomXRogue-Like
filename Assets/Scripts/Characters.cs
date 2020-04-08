using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Characters : MonoBehaviour,IDamageable,IHealable
{
    [Header("Data")]
    [SerializeField] private CharacterData CharacterStats;

    [Header("Camera")]
    [SerializeField] private Transform CharacterCamera ;
    [SerializeField] private float CameraSensitivity = 0.5f ;
    private float xCameraRotation;

    //Controls
    private CharacterControls ActionControls;
    private Vector2 MovementInputs;

    //Components
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
        ActionControls.CharacterMoves.Jump.performed += ctx => Jump();
        ActionControls.Enable();
        RbComponent = GetComponent<Rigidbody>();
    }

    public virtual void OnUpdate()
    {
        Move();
        CameraControl();
    }

    public virtual void Move()
    {
        MovementInputs = ActionControls.CharacterMoves.Movements.ReadValue<Vector2>();
        Vector3 Movement = (transform.forward.normalized * MovementInputs.y * CharacterStats.MoveSpeed) + (transform.right * MovementInputs.x * CharacterStats.MoveSpeed);
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

        Debug.Log(mouseX + "." + mouseY);
    }

    public virtual void Jump()
    {
        RbComponent.AddForce(Vector3.up * CharacterStats.JumpForce, ForceMode.Impulse);
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
