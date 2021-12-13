using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBasicFunction : MonoBehaviour
{
    public GameObject Warrior;
    public GameObject player;
    public int enemySpeed = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MoveToward()
    {
        Vector3 direction = (Warrior.transform.position - transform.position).normalized;
        transform.position += enemySpeed * direction * Time.deltaTime;
    }

    public void LookAtPlayer()
    {
        Vector3 direction = Warrior.transform.position - transform.position;
        Quaternion newRotation = Quaternion.LookRotation(direction);
        transform.rotation = newRotation;
    }
}
