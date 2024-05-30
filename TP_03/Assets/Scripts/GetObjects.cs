using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetObjects : MonoBehaviour
{
    public int foodCount;
    public int maxFood;
    public int drinksCount;
    public int maxDrinks;

    public TextMeshProUGUI numberFood;
    public TextMeshProUGUI numberDrinks;

    private void Update()
    {
        numberFood.text = foodCount.ToString();
        numberDrinks.text = drinksCount.ToString();

    }


    private void OnTriggerEnter(Collider other) // Metodo para saber cuando hemos colisionado con un objeto
    {
        if (other.CompareTag("Alimento") && foodCount < maxFood) // Compara con las etiquetas que hemos agragedo a la lista de Tags
        {
            Destroy(other.gameObject);
            //Debug.Log("Bien, asi debes alimentarte"); // Imprime mensaje por pantalla
            foodCount++;
        }

        if (other.CompareTag("Alimento/No saludable")) // Compara con las etiquetas que hemos agragedo a la lista de Tags
        {
            Destroy(other.gameObject);
            //Debug.Log("Mal, asi dañas tu salud"); // Imprime mensaje por pantalla
            foodCount--;
        }

        if (other.CompareTag("Bebidas") && drinksCount < maxDrinks)
        {
            Destroy(other.gameObject);

            drinksCount++;
        }

    }

}