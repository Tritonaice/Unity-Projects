using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private int speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movementInput = Vector3.zero;
        Debug.Log("Inicio");
        if (Input.GetKey(KeyCode.W))
        {
            movementInput.x = -1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            movementInput.x = 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            movementInput.z = 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            movementInput.z = -1;
        }
        Move(movementInput);


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Destroy(collision.gameObject);
        }
    }
    void Move(Vector3 direction)
    {
        rb.AddForce(direction.normalized * speed, ForceMode.Acceleration);
        //transform.position += direction.normalized * speed * Time.deltaTime;
    }
}

 

