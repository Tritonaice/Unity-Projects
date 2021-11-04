using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private int speed = 1;
    private bool playerScale = false;
    private float timeLeft = 2;
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

    private void OnTriggerStay(Collider collision)
    {
        //Debug.Log("Colisione contra: " + collision.gameObject.GetComponent());

            if (collision.gameObject.CompareTag("Portal") && playerScale)
            {
                transform.localScale = transform.localScale * 2;

                playerScale = false;

            }
            else if (collision.gameObject.CompareTag("Portal") && !playerScale)
            {
                transform.localScale = transform.localScale / 2;
                playerScale = true;
            }
        
            if (collision.gameObject.CompareTag("Wall"))
            {
                timeLeft -= Time.deltaTime;
                Debug.Log(timeLeft);
                if (timeLeft <= 0)
                {
                    Vector3 position = new Vector3(Random.Range(-5f, 5f), 2, Random.Range(-5f, 5f));
                    gameObject.transform.position = position;
                    timeLeft = 2;
            }


            }
        }
    void Move(Vector3 direction)
    {
        rb.AddForce(direction.normalized * speed, ForceMode.Acceleration);
        //transform.position += direction.normalized * speed * Time.deltaTime;
    }
}



