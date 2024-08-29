using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class ControladorCanvas : MonoBehaviour
{
    public GameObject menuPrincipal;
    public GameObject pajarito;
    public GameObject menuMuerte;
    public GameObject menuInGame;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EsconderMenuPrincipal()
    {
        menuPrincipal.SetActive(false);
        pajarito.SetActive(true);
        menuInGame.SetActive(true);

    }

    public void ReiniciarPartida()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    public void EnseñarMenuMuerte()
    {
        menuMuerte.SetActive(true);
        pajarito.SetActive(false);
        menuInGame.SetActive(false);
        
    }
}
