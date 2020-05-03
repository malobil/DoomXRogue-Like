using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager Singleton { get; private set; }

    public TextMeshProUGUI activSpellCd;

    private void Awake()
    {
        if(Singleton != null)
        {
            Destroy(this);
        }
        else
        {
            Singleton = this;
        }
    }

    public void UpdateActivSpellCD(float newCD)
    {
        activSpellCd.text = newCD.ToString("F0");
    }

    
}
