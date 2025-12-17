using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TowerPlacer : MonoBehaviour
{
    public LayerMask groundMask;

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (EventSystem.current.IsPointerOverGameObject()) return;

            if (DraggedTower.Instance.current != null)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out RaycastHit hit, 100f, groundMask))
                {
                    Instantiate(
                        DraggedTower.Instance.current.towerPrefab,
                        hit.point,
                        Quaternion.identity
                    );

                    TowerInventory.Instance.Remove(DraggedTower.Instance.current);
                    DraggedTower.Instance.current = null;
                }
            }
        }
    }
}
