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
    // Start is called before the first frame update
    void Start()
{
    rb = GetComponent<Rigidbody>();
        Player = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {

        Move();
        RotatePlayer();
        if (Input.GetKey("w"))
        {
            transform.position += new Vector3(0, 0, -playerSpeed / 100);

            
        }
        if (Input.GetKey("a"))
        {
            transform.position += new Vector3(playerSpeed / 100, 0, 0);

        }
        if (Input.GetKey("s"))
        {
            transform.position += new Vector3(0, 0, playerSpeed / 100);

        }
        if (Input.GetKey("d"))
        {
            transform.position += new Vector3(-playerSpeed / 100, 0, 0);
        }
        if (Input.GetKeyDown("q") && weapons == false)
        {
            Sword.SetActive(true);
            Gun.SetActive(false);
            weapons = true;
        }
        if (Input.GetKey("q") && weapons == true)
        {
            Sword.SetActive(false);
            Gun.SetActive(true);
            weapons = false;
        }
    }
    private void Move()
    {
        float ejeHorizontal = Input.GetAxisRaw("Horizontal");
        float ejeVertical = Input.GetAxisRaw("Vertical");
        transform.Translate(cameraSpeed * Time.deltaTime * new Vector3(ejeHorizontal, 0, ejeVertical));
    }
    private void RotatePlayer()
    {
        cameraAxis += Input.GetAxis("Mouse X") * 5;
        Quaternion angulo = Quaternion.Euler(0, cameraAxis, 0);
        transform.localRotation = angulo;
    }
    }
