using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{ 
    public int playerForce = 150;
    public int playerHealth = 100;
    public float playerSpeed = 0.00001f;
    [SerializeField] private float cameraSpeed = 3f;
    public string playerName = "Player";
    public SwordController SwordController;
    public GunController GunController;
    public GameObject Gun;
    public GameObject Sword;
    private GameObject Player;
    private float cameraAxis;
    bool weapons = true;
    int playerMovement;
    [SerializeField] private float distance;
    Rigidbody rb;
    public float velocidad;
    // Start is called before the first frame update
    void Start()
{
    rb = GetComponent<Rigidbody>();
        Player = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {

        float mHorizontal = Input.GetAxis("Horizontal");
        float mVertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(mHorizontal, 0.0f, mVertical);

        rb.AddForce(movimiento * velocidad);
        RotatePlayer();
        
    }
    private void RotatePlayer()
    {
        cameraAxis += Input.GetAxis("Mouse X") * 3;
        Quaternion angulo = Quaternion.Euler(0, cameraAxis, 0);
        transform.localRotation = angulo;
    }
    }
