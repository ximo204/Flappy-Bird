using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuberia : MonoBehaviour
{
    public Pajaro scriptPajaro;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(transform.position.x, Random.Range(-0.5f, 0.75f), transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (!scriptPajaro.estaMuerto && scriptPajaro.haClicado)
        {
            transform.position = transform.position - new Vector3(0.8f * Time.deltaTime, 0, 0);

            if (transform.position.x <= -2.5f)
            {
                transform.position = new Vector3(2.5f, Random.Range(-0.5f, 0.75f), transform.position.z);

            }
        }
    }
}
