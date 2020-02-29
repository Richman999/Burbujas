using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorBurbujas : MonoBehaviour
{
    [SerializeField]
    private float altura, extremoIzquierdo, extremoDerecho, profundidad,tiempoCaida;
    [SerializeField]
    private static int numeroBurbujas;
    [SerializeField]
    Burbuja[] burbujas = new Burbuja[numeroBurbujas];
    ETypeBurbuja tipoBurbuja;

    int aseguradorBurbuja;
    float CONTADOR;

    private void Update()
    {
        CONTADOR += Time.deltaTime;
        GenerarBurbuja(burbujas[NumeroBurbuja()]);
    }

    void GenerarBurbuja(Burbuja _burbujaArroja)
    {
        ArmadorBurbuja(_burbujaArroja);
        float posArrojar = Random.Range(extremoIzquierdo, extremoDerecho);
        _burbujaArroja.transform.position = new Vector3 (posArrojar, altura, profundidad);

    }

    void ArmadorBurbuja(Burbuja _burbuja)
    {
        int random = Random.Range(1, 100);

        if(random <= 15)//15%
        {
            tipoBurbuja = ETypeBurbuja.Flirt;
            _burbuja.Material.color = Color.green;
        }
        if (random > 15 && random <= 30)//15%
        {
            tipoBurbuja = ETypeBurbuja.Love;
            _burbuja.Material.color = Color.red;
        }
        if (random > 30 && random<= 45)//15%
        {
            tipoBurbuja = ETypeBurbuja.Intelligence;
            _burbuja.Material.color = Color.blue;
        }
        if(random>45 && random <= 65)//20%
        {
            tipoBurbuja = ETypeBurbuja.Affection;
            _burbuja.Material.color = Color.yellow;
        }
        if (random > 65 && random <= 95)//30%
        {
            tipoBurbuja = ETypeBurbuja.Boorish;
            _burbuja.Material.color = Color.black;
        }
        if(random >95 && random <= 100)//5%
        {
            tipoBurbuja = ETypeBurbuja.Intimacy;
            _burbuja.Material.color = Color.grey;
        }
        _burbuja.SeleccioarTipoBurbuja(tipoBurbuja);

    }


    public int NumeroBurbuja()
    {
        int numeroBurbuja = -1;
        if (CONTADOR >= tiempoCaida)
        {
            if(numeroBurbuja >= burbujas.Length-1)
            {
                numeroBurbuja = -1;
            }
            numeroBurbuja++;
            CONTADOR = 0;
            return numeroBurbuja;
        }
        else
        {
            return burbujas.Length+1;
        }

    }
}
