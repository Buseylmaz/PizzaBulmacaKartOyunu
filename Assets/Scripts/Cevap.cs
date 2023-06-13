using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cevap : MonoBehaviour
{
    
    public Image panel;
   
    public void Cevapla()
    {

        StartCoroutine(Süre());

    }

    IEnumerator Süre()
    {
        panel.enabled = true;
        yield return new WaitForSeconds(3f);
        panel.enabled = false;
    }
}
