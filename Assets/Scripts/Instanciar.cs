using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciar : MonoBehaviour
{
    public GameObject cilindro;
    public GameObject cubo;
    public GameObject esfera;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    // Update is called once per frame
    void Update()
    {

        Vector3 posicion = new Vector3(Random.Range(-10,10),Random.Range(2,4),Random.Range(-10,10));
       
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Instantiate(cilindro, posicion, transform.rotation);
        }
        else if (Input.GetKeyUp(KeyCode.C))
        {
            Instantiate(cubo, posicion, transform.rotation);
        }
        else if (Input.GetKeyUp(KeyCode.V))
        {
            Instantiate(esfera, posicion, transform.rotation);
        }
    }

   
}
