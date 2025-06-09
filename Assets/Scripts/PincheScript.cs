using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PincheScript : MonoBehaviour
{
    public int damage;
    public HealthManager healthManager;

    public void Start()
    {
        healthManager = FindObjectOfType<HealthManager>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(gameObject.name + ": Choqué con " + collision.gameObject.name);
        if (collision.gameObject.name == "Player")
        {
            healthManager.UpdateHealth(-damage);
        }
    }
}
