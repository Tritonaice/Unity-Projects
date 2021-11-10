using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{ 
    public int playerForce = 150;
    public int playerHealth = 100;
    public float playerSpeed = 0.00001f;
    public string playerName = "Player";
    public SwordController SwordController;
    public GunController GunController;
    public GameObject Gun;
    public GameObject Sword;
    private GameObject Player;
    [SerializeField] private int speed = 1;
    bool weapons = true;
    int playerMovement;
    [SerializeField] private float distance;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float cameraSpeed = 3f;
    [SerializeField] private float cameraAxis;
    // Start is called before the first frame update
    void Start()
{
    rb = GetComponent<Rigidbody>();;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movementInput = Vector3.zero;
        RotatePlayer();
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


    }

    void Move(Vector3 direction)
    {
        rb.AddForce(direction.normalized * speed, ForceMode.Acceleration);
        //transform.position += direction.normalized * speed * Time.deltaTime;
    }
    private void Move()
    {
        float ejeHorizontal = Input.GetAxisRaw("Horizontal");
        float ejeVertical = Input.GetAxisRaw("Vertical");
        transform.Translate(cameraSpeed * Time.deltaTime * new Vector3(ejeHorizontal, 0, ejeVertical));
    }
    private void RotatePlayer()
    {
        cameraAxis += Input.GetAxis("Mouse X") * 3;
        Quaternion angulo = Quaternion.Euler(0, cameraAxis, 0);
        transform.localRotation = angulo;
    }
}
