using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int playerLives = 3;
    public string namePlayer = "Sr. Capsula";
    public float speedPlayer = 0.01f;
    public float scalePlayer = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hola");
        transform.position = new Vector3 (0, 0, 0);
        transform.localScale = new Vector3 (3, 1.5f, 3);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, speedPlayer);
    }
}
