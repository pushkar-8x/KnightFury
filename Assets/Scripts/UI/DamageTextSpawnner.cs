using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.UI
{


public class DamageTextSpawnner : MonoBehaviour
{
    
    [SerializeField] DamageText damageTextPrefab;
    void Start()
    {
       
    }

    public void Spawn(float DamageAmount)
    {
            DamageText instance=Instantiate<DamageText>(damageTextPrefab,transform);
            instance.SetValue(DamageAmount);
    }

    
}


}