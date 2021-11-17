using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController: MonoBehaviour
{
    //variable para saltar
    public float jumpForce = 10f;

    //variable para la velocidad del movimiento
    public float velocidadMovimiento = 2f;
    public SpriteRenderer sr;
    public string currentColor;

    //Colores

    public Color colorRed;
    public Color colorBlue;
    public Color colorYellow;
    public Color colorGreen;

    public CubeController Cube;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        SetRandomColor();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //MOVIMIENTO DEL PERSONAJE

        //Saltar, usamos la barra espaciadora para saltar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * jumpForce;
        }

        //Mover a la derecha, usamos la tecla D para movernos a la derecha.
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(velocidadMovimiento, rb.velocity.y);

        }

        //Mover a la izquierda, usamos la tecla A para movernos a la izquierda.
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-velocidadMovimiento, rb.velocity.y);
        }
    }
    void SetRandomColor()
    {
        int index = Random.Range(0, 3);

        switch (index)
        {
            case 0:
                currentColor = "Red";
                sr.color = colorRed;
                break;
            case 1:
                currentColor = "Blue";
                sr.color = colorBlue;
                break;
            case 2:
                currentColor = "Green";
                sr.color = colorGreen;
                break;
            case 3:
                currentColor = "Yellow";
                sr.color = colorYellow;
                break;

        }
    }

    private void OnCollisionEnter2D (Collision2D col)
    {
        if ( Cube.actualColor != currentColor)
        {
            Debug.Log("GAME OVER");
           // transform.position = new Vector2(0, 0);
        }
    }
}

