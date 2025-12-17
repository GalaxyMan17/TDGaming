using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Tower Defense/Tower")]
public class TowerData : ScriptableObject
{
    public string towerName;
    public Sprite icon;
    public GameObject towerPrefab;
}
