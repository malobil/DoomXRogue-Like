using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Character",menuName = "Create a new character")]
public class CharacterData : ScriptableObject
{
    public string CharacterName;
    public float HP;
    public float HPRegain;
    public float Shield;
    public float Damage;
    public float SpellDamage;
    public float CDR;
    public float AtkSpeed;
    public float ReloadSpeed;
    public float MoveSpeed;
    public int JumpNumber;
}
