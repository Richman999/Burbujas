using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Material))]
public class Burbuja : MonoBehaviour
{
    Material myMaterial;
    public Vector3 PosInicial { get; protected set; }

    public ETypeBurbuja TypeBurbuja;

    private void Awake()
    {
        
    }

    public Burbuja(ETypeBurbuja _TypeBurbuja)
    {
        TypeBurbuja = _TypeBurbuja;
    }


    public void SeleccioarTipoBurbuja(ETypeBurbuja _TypeBurbuja)
    {
        TypeBurbuja = _TypeBurbuja;
    }

    private void Start()
    {
        PosInicial = transform.position;
    }
}