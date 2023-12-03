using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class test : MonoBehaviour, IDragHandler, IEndDragHandler, IPointerClickHandler, IPointerDownHandler
{
    Vector3 startPosition;
    Vector3 diffPosition;
    GameObject canvas_;
    GameObject panelGhost;

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition - diffPosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
    
    }

    public void OnPointerClick(PointerEventData eventData)
    {

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        startPosition = transform.position;
        diffPosition = Input.mousePosition - startPosition;
        EventSystem.current.SetSelectedGameObject(gameObject);

        // Check if the object is not already at the top of the hierarchy
        if (transform.GetSiblingIndex() != transform.parent.childCount - 1)
        {
            EventSystem.current.currentSelectedGameObject.transform.SetParent(canvas_.transform);
            EventSystem.current.currentSelectedGameObject.transform.SetAsLastSibling();
        }

        Debug.Log("start drag " + gameObject.name);
    }

    void Start()
    {
        canvas_ = GameObject.Find("Canvas");
        panelGhost = GameObject.Find("Panel ghost");
    }

    void Update()
    {
    
    }
}
