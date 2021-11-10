using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Camera1;
    public GameObject Camera2;
    public GameObject Camera3;
    public GameObject Sound;
    // Start is called before the first frame update
    void Start()
    {

}

    // Update is called once per frame
    void Update()
    {


            //Al pulsar 1 las camaras 2 y 3 se desactivan
            if (Input.GetKeyDown("b"))
            {
            Instantiate(Sound);
            Camera1.SetActive(true);
            Camera2.SetActive(false);
            Camera3.SetActive(false);
            }
            if (Input.GetKeyDown("n"))
            {
            Camera1.SetActive(false);
            Camera2.SetActive(true);
            Camera3.SetActive(false);
            }
            if (Input.GetKeyDown("m"))
            {
            Camera1.SetActive(false);
            Camera2.SetActive(false);
            Camera3.SetActive(true);
            }
        }
    }

