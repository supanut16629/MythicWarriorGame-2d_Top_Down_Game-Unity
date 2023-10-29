using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSource : MonoBehaviour
{
    [SerializeField] private int damageAmount = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        EnermyHealth enermyHealth = collision.gameObject.GetComponent<EnermyHealth>();
        enermyHealth?.TakeDamage(damageAmount);
        
    }
}
