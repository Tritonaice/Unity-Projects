using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint;
    public EnemyController EnemyController;
    public GameObject Sound;

    public float shotForce = 1500;
    public float shotRate = 10f;
    public int shotDamage = 1;
    public float destructionSpeed = 0.5f;

    private float shotRateTime = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("mouse 1"))
        {
            if (Time.time>shotRateTime)
            {
                Instantiate(Sound);

                GameObject newBullet;

                //bullet.transform.localRotation = Quaternion.Euler(0, 0, 180f);

                transform.localRotation = Quaternion.Euler(0, -180f, 0);

                

                newBullet = Instantiate (bullet, position: spawnPoint.position, spawnPoint.rotation);

                
                //EnemyController.enemyHealth -= shotDamage;


                newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward / -1 * shotForce);

                shotRateTime = Time.time + shotRate;

                Destroy(newBullet, destructionSpeed);
            }
        }
        if (Input.GetKeyDown("space"))
        {
            bullet.transform.localScale += (bullet.transform.localScale);
        }
        if (Input.GetKeyDown("e"))
        {
            bullet.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
        }
    }
}

