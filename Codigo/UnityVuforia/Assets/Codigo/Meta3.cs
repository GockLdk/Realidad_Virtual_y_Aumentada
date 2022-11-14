using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meta3 : MonoBehaviour
{
    public GameObject nivel1;
    public GameObject nivel2;
    public GameObject nivel3;
    public GameObject pelota;
    private void OnCollisionEnter(Collision collision)
    {
        Object.Destroy(nivel1);
        Object.Destroy(nivel2);
        Object.Destroy(nivel3);
        Object.Destroy(pelota);

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
