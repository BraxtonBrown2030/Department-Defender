using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class WeaponSo : ScriptableObject
{
    public float weaponDamage;
    public float weaponSpeed;
    public Material weaponMaterial;
    public UnityEvent weaponEvent;
    private WaitForSeconds wfs;

    IEnumerator WeaponPowerCoroutine()
    {
        yield return wfs;
        weaponEvent.Invoke();
    }
    
}
