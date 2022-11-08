using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uno : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "piso")
            Object.Destroy(this.gameObject);
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
