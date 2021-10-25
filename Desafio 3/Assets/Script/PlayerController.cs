using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{ 
public int playerForce = 150;
public int playerHealth = 100;
public float playerSpeed = 0.00001f;
public string playerName = "Warrior";
    public SwordController SwordController;
    public GunController GunController;
    bool weapons = false;

    int playerMovement;
Rigidbody rb;
// Start is called before the first frame update
void Start()
{
    rb = GetComponent<Rigidbody>();
}

    // Update is called once per frame
    void Update()
    {
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
        if (Input.GetKeyDown(KeyCode.Q) && weapons == false)
        {

            SwordController.Sword.SetActive(true);
            GunController.gun.SetActive(false);
            weapons = true;
        }
        else if (Input.GetKey(KeyCode.Q) && weapons == true)
        {
            SwordController.Sword.SetActive(false);
            GunController.gun.SetActive(true);
            weapons = false;
        }
    }
    }