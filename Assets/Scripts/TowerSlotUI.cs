using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TowerSlotUI : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public TowerData tower;
    public Image icon;

    private RectTransform rect;
    private Canvas canvas;
    private Vector2 startPos;

    void Start()
    {
        rect = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
        startPos = rect.anchoredPosition;
        icon.sprite = tower.icon;
    }

    public void OnBeginDrag(PointerEventData evt)
    {
        DraggedTower.Instance.current = tower;
        icon.raycastTarget = false;
    }

    public void OnDrag(PointerEventData evt)
    {
        rect.anchoredPosition += evt.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData evt)
    {
        icon.raycastTarget = true;
        rect.anchoredPosition = startPos;
    }
}
