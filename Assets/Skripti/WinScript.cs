using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour
{
    private int uzvarasPunkt;
    private int Punkti;
    public GameObject objektuSkripts;
  
    void Start()
    {
        uzvarasPunkt = objektuSkripts.transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        //Ja lietotājs saņem vairāk vai vienādus punktus, tad parādās uzvaras logs
        if(Punkti >= uzvarasPunkt)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
    }
    //Punkti skaitisies pēc katras mašīnas
    public void AddPoints()
    {
        Punkti++;
    }
}
