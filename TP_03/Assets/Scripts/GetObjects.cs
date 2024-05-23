using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetObjects : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) // Metodo para saber cuando hemos colisionado con un objeto
    {
        if (other.CompareTag("Alimento")) // Compara con las etiquetas que hemos agragedo a la lista de Tags
        {
            Destroy(other.gameObject);
            Debug.Log("Bien, asi debes alimentarte"); // Imprime mensaje por pantalla
            //AumentasEnergia;
        }

        if (other.CompareTag("Alimento/No saludable")) // Compara con las etiquetas que hemos agragedo a la lista de Tags
        {
            Destroy(other.gameObject);
            Debug.Log("Mal, asi dañas tu salud"); // Imprime mensaje por pantalla
            //DisminuyesEnergia
        }

        /*AumentasEnergia()
        {

        }

        DisminuyesEnergia()
        {

        }*/

    }

}