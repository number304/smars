using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarradeVida : MonoBehaviour
{
    public Image barraDeVida;
    public float vidaActual;
    public float VidaMaxima;

    void Update()
    {
        barraDeVida.fillAmount = vidaActual/VidaMaxima;
    }
}
