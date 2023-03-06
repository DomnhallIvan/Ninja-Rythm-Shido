using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    public float _noteSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.position -= transform.forward * Time.deltaTime * _noteSpeed;
    }
}
