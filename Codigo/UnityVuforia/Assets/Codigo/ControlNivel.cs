using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlNivel : MonoBehaviour
{
    // Pelota
    public GameObject pelota;
    public GameObject botonReinicio;
    public GameObject pelotaActiva;
    public Transform inicioPelota;

    // Niveles
    public GameObject nivel1;
    public GameObject nivel2;
    public GameObject nivel3;
    public GameObject fin;
    public GameObject tiempo;

    // Start is called before the first frame update
    void Start()
    {
        botonReinicio.SetActive(false);

        nivel1.SetActive(true);
        nivel2.SetActive(false);
        nivel3.SetActive(false);

        fin.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (nivel3 != null)
        {
            if (pelotaActiva == null)
            {
                perdio();
                nivel1.SetActive(true);
                nivel2.SetActive(false);
                nivel3.SetActive(false);
                //print("No hay pelota");
            }
        } else
        {
            fin.SetActive(true);
        }
        
    }

    public void reinicio()
    {
        pelotaActiva = Instantiate(pelota, inicioPelota);
        botonReinicio.SetActive(false);
        nivel1.SetActive(true);
        nivel2.SetActive(false);
        nivel3.SetActive(false);
        tiempo.SetActive(false);
    }

    public void perdio()
    {
        botonReinicio.SetActive(true);
    }
}
