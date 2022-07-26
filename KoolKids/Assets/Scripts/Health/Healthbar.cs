using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
 {
    [SerializeField] private Health playerHealth;
    [SerializeField] private Image totalealthBar;
    [SerializeField] private Image currenthealthBar;
    
    void Start()
    {
        totalealthBar.fillAmount = playerHealth.currentHealth / 3;
    }

    void Update()
    {
        currenthealthBar.fillAmount = playerHealth.currentHealth / 3;
    }
}
