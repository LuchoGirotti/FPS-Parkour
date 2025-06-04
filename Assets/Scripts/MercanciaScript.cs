using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercanciaScript : MonoBehaviour
{
    public int precio;
    public MoneyManager moneyManager;

    public void Start()
    {
        moneyManager = FindObjectOfType<MoneyManager>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(gameObject.name + ": Choqué con " + collision.gameObject.name);
        if (collision.gameObject.name == "Player")
        {
            if (moneyManager.UpdateMoney(-precio))
            {
                Destroy(gameObject);
            }
        }
    }
}
