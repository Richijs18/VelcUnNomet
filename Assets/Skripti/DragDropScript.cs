using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDropScript : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler , IEndDragHandler {
    public Objekti objektuSkripts;
    private CanvasGroup kanvasGrupa;
    private RectTransform velkObjRectTrasf;


    void Awake()
    {

        kanvasGrupa = GetComponent<CanvasGroup>();

        velkObjRectTrasf = GetComponent<RectTransform>();

    }

 public void OnPointerDown(PointerEventData notikums)
    {
        Debug.Log("Uzklikšķināts uz velkamā objekta!");
    }

    public void OnBeginDrag(PointerEventData notikums)
    {
        Debug.Log("Uzskākta vilkšana!");

        kanvasGrupa.alpha = 0.6f;

        kanvasGrupa.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData notikums)
    {
        Debug.Log("Notike vilkšana!");
      velkObjRectTrasf.anchoredPosition += notikums.delta / objektuSkripts.kanva.scaleFactor;
    }
    public void OnEndDrag(PointerEventData notikums)
    {

        objektuSkripts.pedejaisVilktais = notikums.pointerDrag;
        Debug.Log("Pēdējais vilktias objekts: " + objektuSkripts.pedejaisVilktais);
        Debug.Log("Beigta vilkšana!");
        kanvasGrupa.alpha = 1f;
        if (objektuSkripts.vaiIstajaVieta == false)
        {
            kanvasGrupa.blocksRaycasts = true;
        }
        else
        {
            objektuSkripts.pedejaisVilktais = null;
        }
        objektuSkripts.vaiIstajaVieta = false;

    }
}
