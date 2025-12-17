using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSelectionUI : MonoBehaviour
{
    public static GameObject SelectedTowerPrefab;

    public void SelecteTower(GameObject TowerPrefab)
    {
        if(TowerPrefab == SelectedTowerPrefab)
        {
            SelectedTowerPrefab = null;
            return;
        }
        SelectedTowerPrefab = TowerPrefab;
    }
}