using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Weapons;

public class PlayerEvents
{
    public delegate void OnWeaponEquippedEvent(WeaponComponent weaponComponent);

    public static event OnWeaponEquippedEvent OnWeaponEquipped;

    public static void Invoke_OnWeaponEquipped(WeaponComponent weaponComponent)
    {
        OnWeaponEquipped?.Invoke(weaponComponent);
    }

    public delegate void OnHealthIntializedEvent(HealthComponent healthComponent);

    public static event OnHealthIntializedEvent onHealthIntialized;

    public static void Invoke_OnHealthIntialized(HealthComponent healthComponent)
    {
        onHealthIntialized?.Invoke(healthComponent);
    }


}
