using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : EnemyBasicFunction
{
    public int enemyHealth = 100;
    public int enemyLife = 3;
    public GameObject enemySound;
    private PlayerController PlayerController;
    [SerializeField] private Transform enemyDistance;
    [SerializeField] private Transform playerDistance;
    public enum Variations
    {
        VOne,
        VTwo
    }
    public Variations Variate;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        float distance = Vector3.Distance(player.transform.position, transform.localPosition) - 16f;
        switch (Variate)
        {
            case Variations.VOne:
                {

                    if (distance > 2f)
                    {
                        LookAtPlayer();
                        MoveToward();
                    }
                    else if (distance <= 2f)
                    {
                        Debug.Log("Stop Enemy 2");
                        break;
                    }

                    break;
                }
            case Variations.VTwo:
                {
                    LookAtPlayer();
                    break;
                }
        }
    }
   /* private void MoveToward()
    {
        Vector3 direction = (Warrior.transform.position - transform.position).normalized;
        transform.position += enemySpeed * direction * Time.deltaTime;
    }

    private void LookAtPlayer()
    {
        Vector3 direction = Warrior.transform.position - transform.position;
        Quaternion newRotation = Quaternion.LookRotation(direction);
        transform.rotation = newRotation;
    }*/
}
