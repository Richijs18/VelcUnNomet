using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour
{
    private int uzvarasPunkt;
    private int Punkti;
    public GameObject objektuSkripts;
    // Start is called before the first frame update
    void Start()
    {
        uzvarasPunkt = objektuSkripts.transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        if(Punkti >= uzvarasPunkt)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
    }

    public void AddPoints()
    {
        Punkti++;
    }
}
