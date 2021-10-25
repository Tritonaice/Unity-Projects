using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int enemyHealth = 100;
    public int enemyLife = 3;
    public float enemySpeed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame


   void Update()
    {
        if (enemyHealth <= 0 && enemyLife == 0)
        {
            Destroy(gameObject);
            Debug.Log("Enemigo destruido");
        }
        else if (enemyHealth == 0)
        {
            enemyLife--;
            enemyHealth += 100;
            Debug.Log("El enemigo tiene " + enemyLife + " vidas");
            Debug.Log("El enemigo tiene " + enemyHealth + " de vida");
        }



    }
}
