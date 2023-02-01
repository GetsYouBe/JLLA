using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class Card : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField]
    private Transform areaTransform;
    [SerializeField]
    private TextMeshProUGUI kana;
    public bool isAnswer = false;
    private bool isMoved = false;

    public void OnPointerClick(PointerEventData eventData)
    {
        if(!isMoved){
            Debug.Log("OnPointerClick");
            Judgment();
        }
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("OnPointerUp");
    }

    void Judgment()
    {
        if(isAnswer){
            isMoved = true;
            Instantiate(transform, transform.position, Quaternion.identity, areaTransform);
            Correct();
        }
        else{
            Incorrect();
        }
    }
    void Correct()
    {

    }
    void Incorrect()
    {

    }
}
