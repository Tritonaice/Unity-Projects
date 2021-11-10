using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int enemyHealth = 100;
    public int enemyLife = 3;
    public float enemySpeed = 0.5f;
    public GameObject enemySound;
    public GameObject Warrior;
    private GameObject player;
    private PlayerController PlayerController;
    [SerializeField] private Transform enemyDistance;
    [SerializeField] private Transform playerDistance;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame


   void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        //El -16f es porque cuando estoy pegado al enemy me da distancia 13,9. Restandole 16 ahi logro que me quede 2 de distancia
        float distance = Vector3.Distance(player.transform.position, transform.localPosition) - 16f;
        //Debug.Log("Distancia entre Enemy y Player:" + distance);
        if (enemyHealth <= 0 && enemyLife == 0)
        {
            Destroy(gameObject);
            Instantiate(enemySound);
            Debug.Log("Enemigo destruido");
        }
        else if (enemyHealth == 0)
        {
            enemyLife--;
            enemyHealth += 100;
            Debug.Log("El enemigo tiene " + enemyLife + " vidas");
            Debug.Log("El enemigo tiene " + enemyHealth + " de vida");
        }
        if (distance > 2f)
        {
            MoveToward();
            LookAtPlayer();
        }
        else if (distance <= 2f)
        {
            Debug.Log("Stop");
        }


    }
    private void MoveToward()
    {
        Vector3 direction = (Warrior.transform.position - transform.position).normalized;
        transform.position += enemySpeed * direction * Time.deltaTime;
    }

    private void LookAtPlayer()
    {
        Vector3 direction = Warrior.transform.position - transform.position;
        Quaternion newRotation = Quaternion.LookRotation(direction);
        transform.rotation = newRotation;
    }
}
