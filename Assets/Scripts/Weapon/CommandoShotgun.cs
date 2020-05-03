using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandoShotgun : Weapon
{
    [SerializeField] private int m_bulletPerShot = 5;
    [SerializeField] private float m_spreadAngle = 80f;
    [SerializeField] private GameObject m_BulletPrefab;

    public override void Shot()
    {
        float shotDamage = associateCharacter.GetCurrentStats().CurrentDamage / m_bulletPerShot;

        for (int i = 0; i < m_bulletPerShot; i++)
        {
            GameObject NewBullet = Instantiate(m_BulletPrefab, transform.position, associateCharacter.GetCamera().transform.rotation);
            Quaternion bulletRotation = NewBullet.transform.rotation;
            bulletRotation.x += Random.Range(-m_spreadAngle, m_spreadAngle);
            bulletRotation.y += Random.Range(-m_spreadAngle, m_spreadAngle);
            NewBullet.transform.rotation = Quaternion.RotateTowards(NewBullet.transform.rotation, Random.rotation, m_spreadAngle);
            NewBullet.GetComponent<Bullet>().SetupBulletDatas(shotDamage, associateCharacter.GetCurrentStats().CurrentRange, transform.position);
        }
    }
}
