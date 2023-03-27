using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List_Of_Effects : MonoBehaviour
{
    public GameObject[] Effects;
    public float PlayerComboScore;

    public void WomboCombo(float Combo)
    {
         PlayerComboScore = PlayerComboScore + Combo;
        if (PlayerComboScore==5)
        {
           Effects[0].gameObject.SetActive(true);
        }
        if (PlayerComboScore == 10)
        {
             Effects[1].gameObject.SetActive(true);
        }
        if (PlayerComboScore == 25)
        {
            Effects[2].gameObject.SetActive(true);
        }
        if (PlayerComboScore == 50)
        {
             Effects[3].gameObject.SetActive(true);
        }
    }

}
