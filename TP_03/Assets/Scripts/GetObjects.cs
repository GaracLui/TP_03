using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GetObjects : MonoBehaviour
{
    public int foodCount;
    public int maxFood;
    public int drinksCount;
    public int maxDrinks;

    public TextMeshProUGUI numberFood;
    public TextMeshProUGUI numberDrinks;
    public TextMeshProUGUI MaxFood;
    public TextMeshProUGUI MaxDrinks;

    private void Update()
    {
        // actual cantidad de objetos
        numberFood.text = foodCount.ToString();
        numberDrinks.text = drinksCount.ToString();

        // Maxima cantidad de objetos
        MaxFood.text = maxFood.ToString();
        MaxDrinks.text = maxDrinks.ToString();

        // Comprueva que consiguio las comidas y bebidas
        if (drinksCount == maxDrinks && foodCount == maxFood)
        {
            // comprueva si esta en el ultimo nivel
            if ((SceneManager.GetActiveScene().buildIndex) == 3)
            {
                SceneManager.LoadScene("Main_Scene"); // Regresa a Main_Scene
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }

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
            //Debug.Log("Mal, asi da�as tu salud"); // Imprime mensaje por pantalla
            foodCount--;
        }

        if (other.CompareTag("Bebida") && drinksCount < maxDrinks)
        {
            Destroy(other.gameObject);

            drinksCount++;
        }

        

    }

}