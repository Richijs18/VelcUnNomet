using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour
{
    //Nosauc jaunos visus mainīgos
    public GameObject atkritumuMasina;
    public GameObject atroMasina;
    public GameObject autobuss;
    public GameObject uguns;
    public GameObject policija;
    public GameObject b2;
    public GameObject e46;
    public GameObject cementaMas;
    public GameObject Eskavators;
    public GameObject traktors1;
    public GameObject traktors5;
    //Nosauc visas mainīgo koordinātes
    [HideInInspector]
    public Vector2 atkrKoord;
    [HideInInspector]
    public Vector2 atroKoord;
    [HideInInspector]
    public Vector2 bussKoord;
    [HideInInspector]
    public Vector2 ugunsKoord;
    [HideInInspector]
    public Vector2 policKoord;
    [HideInInspector]
    public Vector2 b2Koord;
    [HideInInspector]
    public Vector2 e46Koord;
    [HideInInspector]
    public Vector2 cementKoord;
    [HideInInspector]
    public Vector2 eskavKoord;
    [HideInInspector]
    public Vector2 trak1Koord;
    [HideInInspector]
    public Vector2 trak5Koord;
    public Canvas kanva;
    public AudioSource skanasAvots;
    public AudioClip[] skanaKoAtskanot;
    public GameObject pedejaisVilktais = null;
    [HideInInspector]
    public bool vaiIstajaVieta = false;

    //Mainīgo atrašānās vietas
    private void Awake()
    {
        atkrKoord = atkritumuMasina.GetComponent<RectTransform>().localPosition;
        atroKoord = atroMasina.GetComponent<RectTransform>().localPosition;
        bussKoord = autobuss.GetComponent<RectTransform>().localPosition;
        ugunsKoord = uguns.GetComponent<RectTransform>().localPosition;
        policKoord = policija.GetComponent<RectTransform>().localPosition;
        b2Koord = b2.GetComponent<RectTransform>().localPosition;
        e46Koord = e46.GetComponent<RectTransform>().localPosition;
        cementKoord = cementaMas.GetComponent<RectTransform>().localPosition;
        eskavKoord = Eskavators.GetComponent<RectTransform>().localPosition;
        trak1Koord = traktors1.GetComponent<RectTransform>().localPosition;
        trak5Koord = traktors5.GetComponent<RectTransform>().localPosition;
    }
}
