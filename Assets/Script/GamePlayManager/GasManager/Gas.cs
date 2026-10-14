using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gas : MonoBehaviour
{
    public float gasAmount = 25f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GasManager gas = FindObjectOfType<GasManager>();

            if (gas != null)
                gas.Addgas(gasAmount);

            Destroy(gameObject);
            AudioManager.Instance.PlaySFX("Gas");
        }
    }
}
