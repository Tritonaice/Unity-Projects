using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordController : MonoBehaviour
{
    public int swordDamage = 1;
    public EnemyController EnemyController;
    public GameObject Sword;
    public GunController GunController;
    private bool swordController = true;
     bool weapons = false;

    // Start is called before the first frame update
    void Start()
    {
        EnemyController = FindObjectOfType<EnemyController>();
        Debug.Log(EnemyController.enemyHealth);
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKey("mouse 0") && swordController == false) //Click derecho
            {
                //transform.position += new Vector3(0, +0.2f / 100, 0);
                transform.localRotation = Quaternion.Euler(0, 0, 0);
                swordController = true;
            }
            else if (Input.GetKey("mouse 0") && swordController == true)
            {
                transform.localRotation = Quaternion.Euler(-90f, 0, 0);
                swordController = false;
                if (EnemyController.enemyHealth > 0)
                {
                    EnemyController.enemyHealth -= swordDamage / 30;
                }

        }
    }
}
