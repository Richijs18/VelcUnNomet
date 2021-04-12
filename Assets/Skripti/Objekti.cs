﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour
{
    public GameObject atkritumuMasina;
    public GameObject atroMasina;
    public GameObject autobuss;

    [HideInInspector]
    public Vector2 atkrKoord;
    [HideInInspector]
    public Vector2 atroKoord;
    [HideInInspector]
    public Vector2 bussKoord;
    public Canvas kanva;
    public AudioSource skanasAvots;
    public AudioClip[] skanaKoAtskanot;
    public GameObject pedejaisVilktais = null;
    [HideInInspector]
    public bool vaiIstajaVieta = false;


    private void Awake()
    {
        atkrKoord = atkritumuMasina.GetComponent<RectTransform>().localPosition;
        atroKoord = atroMasina.GetComponent<RectTransform>().localPosition;
        bussKoord = autobuss.GetComponent<RectTransform>().localPosition;
    }
}
