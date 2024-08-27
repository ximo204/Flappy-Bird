using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pajaro : MonoBehaviour
{
    public Rigidbody2D cuerpoPajaro;
    public bool estaMuerto = false;
    public bool haClicado = false;
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
                cuerpoPajaro.velocity = new Vector2(0, 3.5f);
            }
            else
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(0);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!estaMuerto)
        {
            estaMuerto=true;
            cuerpoPajaro.velocity = new Vector2(0, 0);
        }
    }
}
