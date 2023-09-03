using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndMerge : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
    private RectTransform rectTransform;
    private Canvas canvas;
    private CanvasGroup canvasGroup;
	
	public Transform ilkResim;
    public Transform ikinciResim;
	int oldu = 0;

    private Vector2 initialPosition;
    private bool isOverlapping = false;
    private DragAndMerge otherDragAndDrop; // Reference to the other DragAndDrop script
	
    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        initialPosition = rectTransform.anchoredPosition;
        canvasGroup.alpha = 0.6f;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 localPoint;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(rectTransform.parent as RectTransform, eventData.position, eventData.pressEventCamera, out localPoint))
        {
            rectTransform.localPosition = localPoint;
        }

        if (isOverlapping && otherDragAndDrop != null)
        {
            Vector3 distance = rectTransform.position - otherDragAndDrop.rectTransform.position;
            float overlapDistance = Mathf.Abs(distance.magnitude);
            
            if (overlapDistance <= 50f) // You can adjust this threshold based on your needs
            {
                // Combine the two images here
                // For example, you can deactivate this drag-and-drop script and set the position of one image to the other
                // Deactivate this script
                this.enabled = false;
                // Set the position of the other image to this image
                otherDragAndDrop.rectTransform.anchoredPosition = rectTransform.anchoredPosition;

                // You can also destroy the other image if needed
                // Destroy(otherDragAndDrop.gameObject);
            }
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
    }

    public void SetOverlapping(bool value, DragAndMerge other)
    {
        isOverlapping = value;
        otherDragAndDrop = other;
    }
}
