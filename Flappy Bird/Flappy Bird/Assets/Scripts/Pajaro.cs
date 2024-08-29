using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Pajaro : MonoBehaviour
{
    public Rigidbody2D cuerpoPajaro;
    public bool estaMuerto = false;
    public bool haClicado = false;
    public ControladorCanvas controladorCanvas;
    public int puntuacion = 0;
    public TextMeshProUGUI textoPuntuacion, textoMuerte, textoMejorPuntuacion;
    public GameObject medallaBronce, medallaPlata, medallaOro;
    // Start is called before the first frame update
    void Start()
    {
        cuerpoPajaro.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            cuerpoPajaro.gravityScale = 1;
            haClicado = true; 
            if (!estaMuerto)
            {
                cuerpoPajaro.velocity = new Vector2(0, 2.5f);
                cuerpoPajaro.SetRotation(30);
            }
        }

        textoPuntuacion.text = puntuacion.ToString();

        if(cuerpoPajaro.velocity.y < 0)
        {
            cuerpoPajaro.SetRotation(cuerpoPajaro.rotation - 300 * Time.deltaTime);
            cuerpoPajaro.SetRotation(Mathf.Clamp(cuerpoPajaro.rotation, -90, 30));
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!estaMuerto)
        {
            estaMuerto=true;
            cuerpoPajaro.velocity = new Vector2(0, 0);
            controladorCanvas.Invoke("EnseñarMenuMuerte", 0.3f);
            textoMuerte.text = puntuacion.ToString();
            GuardarPuntuacionMaxima();
            if (puntuacion > 3)
            {
                medallaOro.SetActive(true);
            }
            else if(puntuacion > 2)
            {
                medallaPlata.SetActive(true);
            }else if(puntuacion > 1)
            {
                medallaBronce.SetActive(true); 
            }
        }
    }
    public void GuardarPuntuacionMaxima()
    {
        if (PlayerPrefs.GetInt("PuntuacionMaxima", 0) < puntuacion)
        {
            PlayerPrefs.SetInt("PuntuacionMaxima", puntuacion);
            
        }
        textoMejorPuntuacion.text = PlayerPrefs.GetInt("PuntuacionMaxima").ToString();
    }
    public void IncrementarPuntuacion()
    {
        puntuacion++;
    }
}
