using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Notes"))
        {
            Debug.Log("Colisione");
            Destroy(other.gameObject);
        }
    }
}
