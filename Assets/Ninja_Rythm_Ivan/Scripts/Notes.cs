using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    public List_Of_Effects Efectos;

    private void Start()
    {
        Efectos = GameObject.FindObjectOfType<List_Of_Effects>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Notes"))
        {
            Destroy(other.gameObject);
            Efectos.Effects[3].Play();
            Efectos.Bruh();
        }
    }
}
