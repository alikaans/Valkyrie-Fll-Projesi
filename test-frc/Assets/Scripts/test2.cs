using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class test2 : MonoBehaviour, IDropHandler, IPointerClickHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        UIDrag draggable = eventData.pointerDrag.GetComponent<UIDrag>();

        // Check if the dragged object is not already a child of the drop target
        if (draggable != null && !transform.IsChildOf(draggable.transform))
        {
            draggable.transform.SetParent(transform);

            var sizey = GetComponent<RectTransform>().rect.size.y;
            int index = (int)((((transform.position.y + (sizey / 2)) - Input.mousePosition.y)) / 35) + 1;
            if (index <= 0)
            {
                index = 1;
            }
            draggable.transform.SetSiblingIndex(index);

            // rebuilds the layout and its child elements
            LayoutRebuilder.ForceRebuildLayoutImmediate(GetComponent<RectTransform>());
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {

    }

    void Start()
    {

    }

    void Update()
    {

    }
}
