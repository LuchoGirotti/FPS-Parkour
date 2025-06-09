using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    public float health;
    public TextMeshProUGUI cartel;

    public bool UpdateHealth(float amount)
    {
        if (health + amount <= 0)
        {
         SceneManager.LoadScene("Parkour");
            Debug.Log("Moriste");
            return false;
        }
        else
        {
            health += amount;
            return true;
        }
    }

    public void Update()
    {
        cartel.text = "HP: " + health;
    }
}
