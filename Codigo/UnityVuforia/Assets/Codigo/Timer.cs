using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeStart;
    public Text textBox;
    public GameObject nivel1;
    public GameObject nivel2;
    public GameObject nivel3;
    public GameObject tiempo;
    public GameObject botonReinicio;


    // Start is called before the first frame update
    void Start()
    {
        tiempo.SetActive(false);
        textBox.text = timeStart.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(nivel3 != null & timeStart > 0.0)
        {
            timeStart -= Time.deltaTime;
            textBox.text = Mathf.Round(timeStart).ToString();
        } else
        {
            nivel1.SetActive(false);
            nivel2.SetActive(false);
            nivel3.SetActive(false);

            tiempo.SetActive(true);
            botonReinicio.SetActive(true);
            timeStart = 300;
        }
        
    }
}

