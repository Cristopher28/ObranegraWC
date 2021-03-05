using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuInventory : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform personaje;
    public Transform peto;
    public Transform casco;
    public Transform arma;


    public void Personaje()
    {
        if (personaje.gameObject.activeSelf == false)
        {
            personaje.gameObject.SetActive(true);
            peto.gameObject.SetActive(false);
            casco.gameObject.SetActive(false);
            arma.gameObject.SetActive(false);
        }
        else
        {
            personaje.gameObject.SetActive(false);
            peto.gameObject.SetActive(false);
            casco.gameObject.SetActive(false);
            arma.gameObject.SetActive(false);
        }
    }

    public void Peto()
    { 
        if (peto.gameObject.activeSelf == false)
        {
            personaje.gameObject.SetActive(false);
        peto.gameObject.SetActive(true);
        casco.gameObject.SetActive(false);
        arma.gameObject.SetActive(false);
        }
        else
        {
            personaje.gameObject.SetActive(false);
            peto.gameObject.SetActive(false);
            casco.gameObject.SetActive(false);
            arma.gameObject.SetActive(false);
        }
    }
    public void Casco()
    {
        if (casco.gameObject.activeSelf == false)
        {
            personaje.gameObject.SetActive(false);
            peto.gameObject.SetActive(false);
            casco.gameObject.SetActive(true);
            arma.gameObject.SetActive(false);
        }
        else
        {
            personaje.gameObject.SetActive(false);
            peto.gameObject.SetActive(false);
            casco.gameObject.SetActive(false);
            arma.gameObject.SetActive(false);
        }
    }
    public void Arma()
    {
        if (arma.gameObject.activeSelf == false)
        {
            personaje.gameObject.SetActive(false);
            peto.gameObject.SetActive(false);
            casco.gameObject.SetActive(false);
            arma.gameObject.SetActive(true);
        }
        else
        {
            personaje.gameObject.SetActive(false);
            peto.gameObject.SetActive(false);
            casco.gameObject.SetActive(false);
            arma.gameObject.SetActive(false);
        }
    }

}
