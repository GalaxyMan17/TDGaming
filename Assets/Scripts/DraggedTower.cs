using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggedTower : MonoBehaviour
{
    public static DraggedTower Instance;
    public TowerData current;

    private void Awake() => Instance = this;
}
