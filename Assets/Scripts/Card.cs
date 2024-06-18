using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Card : MonoBehaviour
{
    public string figura;
    public int numero;

    [SerializeField] private SpriteRenderer spriteR;
    [SerializeField] private Sprite[] figuras1;
    [SerializeField] private Sprite[] figuras2;
    [SerializeField] private Sprite[] figuras3;
    [SerializeField] private Sprite[] figuras4;

    public void Setup(string cartaFigura, int cartaNumero)
    {
        figura = cartaFigura;
        numero = cartaNumero;

        if(figura == "Diamante")
        {
            Diamante(numero);
        }
        else if(figura == "Corazon")
        {
            Corazon(numero); 
        }
        else if (figura == "Trebol")
        {
            Trebol(numero);
        }
        else if (figura == "Pica")
        {
            Pica(numero);
        }
        else
        {
            Debug.Log("Algo salio mal");
        }
    }

    private void Diamante(int indice) { spriteR.sprite = figuras1[indice]; }

    private void Corazon(int indice) { spriteR.sprite = figuras2[indice]; }

    private void Trebol(int indice) { spriteR.sprite = figuras3[indice]; }

    private void Pica(int indice) { spriteR.sprite = figuras4[indice]; }

}
