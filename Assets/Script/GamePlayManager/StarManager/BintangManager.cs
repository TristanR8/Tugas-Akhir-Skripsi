using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BintangManager : MonoBehaviour
{
    public Image[] star;

    public void Setstar(int coin)
    {
        if (coin >= 6)
        {
            star[0].enabled = true;
            star[1].enabled = true;
            star[2].enabled = true;
        }
        else if (coin >= 2)
        {
            star[0].enabled = true;
            star[1].enabled = true;
        }
        else if (coin >= 1)
        {
            star[0].enabled = true;
        }
    }
}
