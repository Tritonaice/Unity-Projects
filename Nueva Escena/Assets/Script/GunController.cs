using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GunController : MonoBehaviour
{
    public GameObject gun;
    public Transform spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        GameObject gunPosition;
        gunPosition = Instantiate(gun, spawnPoint.position, spawnPoint.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
