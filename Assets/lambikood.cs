using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class lambikood : MonoBehaviour
{

    public bool vilgub = false;
    public float vaheaeg;

    void Update()
    {
        if (vilgub == false) 
        { 
            StartCoroutine(VilkuvTuli()); 
        }

    }

    IEnumerator VilkuvTuli()
    {
        vilgub = true;
        this.gameObject.GetComponent<Light>().enabled = false;
        vaheaeg = Random.Range(0.01f, 0.4f);
        yield return new WaitForSeconds(vaheaeg);
        this.gameObject.GetComponent<Light>().enabled = true;
        vaheaeg = Random.Range(0.01f, 0.4f);
        yield return new WaitForSeconds(vaheaeg);
        vilgub = false;
    }

}
