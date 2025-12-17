using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TowerHotbarUI : MonoBehaviour
{
    public GameObject slotPrefab;

    void Start()
    {
        Refresh();
    }

    public void Refresh()
    {
        foreach (Transform c in transform)
            Destroy(c.gameObject);

        foreach (var tower in TowerInventory.Instance.towers)
        {
            var go = Instantiate(slotPrefab, transform);
            var slot = go.GetComponent<TowerSlotUI>();
            slot.tower = tower;
        }
    }
}
