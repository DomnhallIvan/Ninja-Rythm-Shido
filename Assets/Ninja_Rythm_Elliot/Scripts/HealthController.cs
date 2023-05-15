using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    public int playerHealth = 3;
    [SerializeField] private Image[] hearts;
    // Start is called before the first frame update
    void Start()
    {
       
    }
    private void Update()
    {
        
        UpdateHealth();
    }
    public void UpdateHealth()
    {
        for (int i = 0; i < hearts.Length; i++) 
        {
            if(i < playerHealth)
            {
                hearts[i].color = Color.red;
            }
            else
            {
                hearts[i].color= Color.black;
            }
        }
    }
}
