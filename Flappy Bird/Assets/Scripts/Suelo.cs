using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suelo : MonoBehaviour
{
    public Transform transformDelOtroSuelo;
    public Pajaro scriptPajaro;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!scriptPajaro.estaMuerto && scriptPajaro.haClicado)
        {
            transform.position = transform.position - new Vector3(0.8f * Time.deltaTime, 0, 0);

            if (transform.position.x <= -5f)
            {
                transform.position = new Vector3(transformDelOtroSuelo.position.x + 5f, transformDelOtroSuelo.position.y, transformDelOtroSuelo.position.z);

            }
        }
    }
}
