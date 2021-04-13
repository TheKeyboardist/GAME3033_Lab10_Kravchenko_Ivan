using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using Systems.Health;

public class HealthInfoUI : MonoBehaviour
{
    [SerializeField] TMP_Text HealthText;
    private HealthComponent playerHealthComponent;

    private void OnEnable()
    {
        PlayerEvents.onHealthIntialized += onHealthIntialized;
    }

    private void onHealthIntialized(HealthComponent healthComponent)
    {
        playerHealthComponent = healthComponent;
    }


    private void OnDisable()
    {
        PlayerEvents.onHealthIntialized -= onHealthIntialized;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HealthText.text = playerHealthComponent.Health.ToString();
    }
}
