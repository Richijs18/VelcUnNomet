using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjektuTransormacij : MonoBehaviour
{

    public Objekti objektuSkripts;


    void Update()
    {
        //Uzspiežot z burtu griežas pulsteņrādītāj virzienā, Uzspiežot x burtu griežas pret pulksteņrādītāj virzienā.
        if (objektuSkripts.pedejaisVilktais != null)
        {


            if (Input.GetKey(KeyCode.Z))
            {
                objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.Rotate(0, 0, Time.deltaTime * 9f);
            }

            if (Input.GetKey(KeyCode.X))
            {
                objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.Rotate(0, 0, -Time.deltaTime * 9f);
            }

            //Uzspiežot kreiso pogu mašinas saraujas, Uzspiežot labo pogu mašinas paplašinās.
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                if (objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.x > 0.35)
                {
                    objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale =
                        new Vector2(objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.x - 0.001f,
                    objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.y);
                }
            }


            if (Input.GetKey(KeyCode.RightArrow))
            {
                if (objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.x < 0.9)
                {
                    objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale =
                        new Vector2(objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.x + 0.001f,
                    objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.y);
                }
            }

            //Uzspiežot pogu uz augšu mašīnas paliek augstākas, Uzspiežot pogu uz leju mašīnas paliek zemākas
            if (Input.GetKey(KeyCode.UpArrow))
            {
                if (objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.x < 0.8)
                {
                    objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale =
                        new Vector2(objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.x,
                    objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.y + 0.001f);
                }
            }


            if (Input.GetKey(KeyCode.DownArrow))
            {
                if (objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.x > 0.35)
                {
                    objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale =
                        new Vector2(objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.x,
                    objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.y - 0.001f);
                }
            }

        }
    }
}
