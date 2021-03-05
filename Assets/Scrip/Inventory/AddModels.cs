using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddModels : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject personaje;
    public GameObject casco;
    public GameObject peto;
    public GameObject arma;
    Quaternion rotation = Quaternion.Euler(0, 0, 0);

    public void Personaje()
    {
        GameObject tmp = Instantiate(personaje);
    }

    public void Casco()
    {
        
        var father = GameObject.FindGameObjectWithTag("Personaje");
        if (father != null)
        {
            Vector3 position = new Vector3(0.014f, 0.571f, 0);
            Vector3 scale = new Vector3(3f, 3f, 3f);
            GameObject tmp = Instantiate(casco);
            tmp.transform.parent = father.transform;
            tmp.transform.localScale = scale;
            tmp.transform.localPosition = position;
        }
    }
    public void Peto()
    {
        var father = GameObject.FindGameObjectWithTag("Personaje");
        if (father != null)
        {
            Vector3 position = new Vector3(0.014f, 0.205f, 0);
            Vector3 scale = new Vector3(3f, 3f, 3f);
            GameObject tmp = Instantiate(peto);
            tmp.transform.parent = father.transform;
            tmp.transform.localScale = scale;
            tmp.transform.localPosition = position;
        }
    }
    public void Arma()
    {
        var father = GameObject.FindGameObjectWithTag("Personaje");
        if (father != null)
        {
            Vector3 position = new Vector3(0.457f, 0.09f, 0);
            Vector3 scale = new Vector3(1f, 1f, 1f);
            GameObject tmp = Instantiate(arma);
            tmp.transform.parent = father.transform;
            tmp.transform.localScale = scale;
            tmp.transform.localPosition = position;
        }
    }
}
