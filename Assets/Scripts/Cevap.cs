using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cevap : MonoBehaviour
{
    
    public Image panel;
   
    public void Cevapla()
    {

        StartCoroutine(S�re());

    }

    IEnumerator S�re()
    {
        panel.enabled = true;
        yield return new WaitForSeconds(3f);
        panel.enabled = false;
    }
}
