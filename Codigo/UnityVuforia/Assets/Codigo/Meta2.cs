using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meta2 : MonoBehaviour
{
    public GameObject nivel1;
    public GameObject nivel2;
    public GameObject nivel3;
    public GameObject pelota;
    private void OnCollisionEnter(Collision collision)
    {
        nivel1.SetActive(false);
        nivel2.SetActive(false);
        nivel3.SetActive(true);
        pelota.transform.position = new Vector3(0, 0.1f, -1);

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
