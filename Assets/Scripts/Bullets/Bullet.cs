using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
    [SerializeField] private float BulletSpeed = 20f;

    public delegate void ActionOnTouch();
    public ActionOnTouch OnTouch ;

    private float BulletDamage;
    private float BulletRange ;
    private Vector3 BulletStartPoint;
    private Rigidbody RbComp;

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

    public virtual void OnEnter()
    {
        
    }

    public virtual void OnUpdate()
    {
        if(Vector3.Distance(BulletStartPoint,transform.position) >= BulletRange)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(OnTouch != null)
        {
            OnTouch();
        }
        Destroy(gameObject);
    }

    public virtual void SetupBulletDatas(float Damage, float Range, Vector3 StartPosition)
    {
        BulletDamage = Damage;
        BulletRange = Range;
        BulletStartPoint = StartPosition;
        RbComp = GetComponent<Rigidbody>();
        RbComp.velocity = transform.forward * BulletSpeed;
    }
}
