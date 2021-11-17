using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    //variable para saltar
    public float jumpForce = 10f;
    private int anterior;
    //variable para la velocidad del movimiento
    public float velocidadMovimiento = 2f;
    public SpriteRenderer sr;
    public string actualColor;

    //Colores

    public SpriteRenderer costado;
    public Color colorRed;
    public Color colorBlue;
    public Color colorYellow;
    public Color colorGreen;

    public int saltos;

    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        SetRandomColor();
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            saltos++;
            if (saltos >= 3)
            {
                SetRandomColor();
                saltos = 0;
            }
        }
    }

    void SetRandomColor()
    {
        int index = Random.Range(0, 4);
        if (anterior == index)
        {
            index = Random.Range(0, 4);
        }
        else
        {
            if (sr.color == costado.color)
            {
             index = Random.Range(0, 4);
             anterior = index;
            }
            switch (index)
            {
                case 0:
                    actualColor = "Red";
                    sr.color = colorRed;
                    break;
                case 1:
                    actualColor = "Blue";
                    sr.color = colorBlue;
                    break;
                case 2:
                    actualColor = "Green";
                    sr.color = colorGreen;
                    break;
                case 3:
                    actualColor = "Yellow";
                    sr.color = colorYellow;
                    break;

            }
        }
    }

}
