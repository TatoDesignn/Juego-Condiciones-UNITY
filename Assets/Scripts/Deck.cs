using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public GameObject cartaPrefab; // Prefab de la carta

    public List<GameObject> cartas = new List<GameObject>();

    private string[] figuras = new string[] { "Diamante", "Corazon", "Trebol", "Pica" };
    private int[] numeros = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};

    void Start()
    {
        CrearBaraja();

        //ShuffleDeck();
        //DealCards();
    }

    void CrearBaraja()
    {
        for (int i = 0; i < 2; i++)
        {
            foreach (string figura in figuras)
            {
                foreach (int numero in numeros)
                {
                    AñadirCarta(figura, numero);
                }
            }
        }
    }
     
    void AñadirCarta(string figura, int numero)
    {
        GameObject nuevaCarta = Instantiate(cartaPrefab);
        nuevaCarta.GetComponent<Card>().Setup(figura, numero);
        cartas.Add(nuevaCarta);
    }

    /*void ShuffleDeck()
    {
        for (int i = 0; i < cartas.Count; i++)
        {
            GameObject temp = cartas[i];
            int randomIndex = Random.Range(i, cartas.Count);
            cartas[i] = cartas[randomIndex];
            cartas[randomIndex] = temp;
        }
    }

    void DealCards()
    {
        foreach (GameObject card in cartas)
        {
            // Lógica para repartir las cartas
            card.transform.position = GetRandomPosition();
        }
    }

    Vector3 GetRandomPosition()
    {
        // Generar una posición aleatoria
        return new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), 0);
    }*/
}
