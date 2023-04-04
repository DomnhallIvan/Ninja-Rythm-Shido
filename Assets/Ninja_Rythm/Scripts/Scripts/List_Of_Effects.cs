using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class List_Of_Effects : MonoBehaviour
{
    
    public Text ScoreText;
    public int PlayerComboScore;

    public Image CoboImage;
    public Sprite[] ComboStoneImage;

    public GameObject[] Effects;


    private void Start()
    {
        PlayerComboScore = 0;
        CoboImage.sprite = ComboStoneImage[0];
    }

    public void DeluxyCombo(int Combo)
    {
        PlayerComboScore += Combo;
        ScoreText.text = ("X " + PlayerComboScore);
        if (PlayerComboScore>=200)
        {
            CoboImage.sprite = ComboStoneImage[6];
        }
        else if(PlayerComboScore>=100)
        {
            CoboImage.sprite=ComboStoneImage[5];
        }
        else if (PlayerComboScore >= 50)
        {
            CoboImage.sprite = ComboStoneImage[4];
        }
        else if (PlayerComboScore >= 25)
        {
            CoboImage.sprite = ComboStoneImage[3];
        }
        else if (PlayerComboScore >= 10)
        {
            CoboImage.sprite = ComboStoneImage[2];
        }
        else if (PlayerComboScore >= 5)
        {
            CoboImage.sprite = ComboStoneImage[1];
        }
        else if(PlayerComboScore>=0)
        {
            CoboImage.sprite = ComboStoneImage[0];
        }
    }

   /* public void WomboCombo(int Combo)
    {
        PlayerComboScore += Combo;
        ScoreText.text = ("X " + PlayerComboScore);
        if (PlayerComboScore >= 200) //Si tiene 5 en combo se activa de lo contrario se desactiva
        {
            Effects[0].gameObject.SetActive(true);
            ComboText[0].gameObject.SetActive(true);
        }
        
        if (PlayerComboScore >= 100 ) //Si tiene 10 en combo se activa de lo contrario se desactiva
        {
            
            Effects[1].gameObject.SetActive(true);
            ComboText[1].gameObject.SetActive(true);
        }
        
        if (PlayerComboScore >= 50 )
        {
            Effects[2].gameObject.SetActive(true);
            ComboText[2].gameObject.SetActive(true);
        }
        
        if (PlayerComboScore == 25 )
        { 
            Effects[3].gameObject.SetActive(true);
            ComboText[3].gameObject.SetActive(true);
        }
        
        if (PlayerComboScore==10 )
        {  
            Effects[4].gameObject.SetActive(true);
            ComboText[4].gameObject.SetActive(true);
        }
       
        if (PlayerComboScore==5)
        {        
            Effects[5].gameObject.SetActive(true);
            ComboText[5].gameObject.SetActive(true);
        }
       
    }*/

    public void Bruh()
    {
        PlayerComboScore = 0;
        ScoreText.text = ("X " + PlayerComboScore);
        if (PlayerComboScore >= 0)
        {
            CoboImage.sprite = ComboStoneImage[0];
        }

    }

   

    /*public void ActivateObjectAtIndex(Image[] ComboText, int Combo)
    {
        for (int i = 0; i < ComboText.Length; i++)
        {
            PlayerComboScore = PlayerComboScore + Combo;
            ScoreText.text = ("X " + PlayerComboScore);
            if (i == 5)
            {
                ComboText[i].gameObject.SetActive(true);
            }
            else
            {
                ComboText[i].gameObject.SetActive(false);
            }
        }
    }*/

}
