using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class List_Of_Effects : MonoBehaviour
{
    public GameObject[] Effects;
    public Text ScoreText;
    public Image[] ComboText;
    public float PlayerComboScore;

    public void WomboCombo(float Combo)
    {
         PlayerComboScore = PlayerComboScore + Combo;
        ScoreText.text = ("X " + PlayerComboScore);
        if (PlayerComboScore==5)
        {
           Effects[0].gameObject.SetActive(true);
            ComboText[0].gameObject.SetActive(true);
        }
        if (PlayerComboScore == 10)
        {
            Effects[0].gameObject.SetActive(false);
            ComboText[0].gameObject.SetActive(false);
            Effects[1].gameObject.SetActive(true);
            ComboText[1].gameObject.SetActive(true);
        }
        if (PlayerComboScore == 25)
        {
            Effects[1].gameObject.SetActive(false);
            ComboText[1].gameObject.SetActive(true);
            Effects[2].gameObject.SetActive(true);
            ComboText[2].gameObject.SetActive(true);
        }
        if (PlayerComboScore == 50)
        {
            Effects[2].gameObject.SetActive(false);
            ComboText[2].gameObject.SetActive(false);
            Effects[3].gameObject.SetActive(true);
            ComboText[3].gameObject.SetActive(true);
        }
        if(PlayerComboScore==100)
        {
            Effects[4].gameObject.SetActive(false);
            ComboText[4].gameObject.SetActive(false);
            Effects[5].gameObject.SetActive(true);
            ComboText[5].gameObject.SetActive(true);
        }
        if(PlayerComboScore==200)
        {
            Effects[5].gameObject.SetActive(false);
            ComboText[5].gameObject.SetActive(false);
            Effects[6].gameObject.SetActive(true);
            ComboText[6].gameObject.SetActive(true);
        }
    }

}
