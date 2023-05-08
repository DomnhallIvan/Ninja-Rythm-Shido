using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    public int playerHealth = 3;
    public GameObject canvasLose;
    public GameObject canvasScore;
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

    public void GameOver()
    {
        if(playerHealth == 0)
        {
            Time.timeScale = 0;
            canvasLose.SetActive(true);
            canvasScore.SetActive(false);
        }
    }

    public void Continue()
    {
        Time.timeScale = 1;
        canvasLose.SetActive(false);
        canvasScore.SetActive(true);
    }
}
