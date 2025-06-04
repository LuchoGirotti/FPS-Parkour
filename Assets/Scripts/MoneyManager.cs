using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyManager : MonoBehaviour
{
    public float money;
    public TextMeshProUGUI cartel;

    public bool UpdateMoney(float amount)
    {
        if (money + amount < 0)
        {
            Debug.Log("No te alcanza");
            return false;
        }
        else
        {
            money += amount;
            return true;
        }
    }

    public void Update()
    {
        cartel.text = "$" + money;
    }
}
