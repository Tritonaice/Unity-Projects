using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CayonController : MonoBehaviour
{
    [SerializeReference] private GameObject Warrior;
    [SerializeField] private float speedToLook = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LookAtPlayer();
    }
    private void LookAtPlayer()
    {
        Vector3 direction = Warrior.transform.position - transform.position;
        Quaternion newRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, speedToLook * Time.deltaTime) ;
    }
}

