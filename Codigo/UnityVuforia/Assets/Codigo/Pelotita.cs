using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelotita : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Piso" | collision.collider.name == "Piso1" | collision.collider.name == "Piso2" | collision.collider.name == "Piso3" | collision.collider.name == "Piso4" | collision.collider.name == "Piso5")
        {
            Object.Destroy(this.gameObject);
            //print("Se cayo");
        }
        // print("Choco");
       
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
