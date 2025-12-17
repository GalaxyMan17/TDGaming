using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerInventory : MonoBehaviour
{
    public static TowerInventory Instance;
    public List<TowerData> towers = new List<TowerData>();

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            Load();
        }
        else
            Destroy(gameObject);
    }

    public void Add(TowerData t)
    {
        towers.Add(t);
        Save();
    }

    public void Remove(TowerData t)
    {
        towers.Remove(t);
        Save();
    }

    public void Save()
    {
        PlayerPrefs.SetInt("count", towers.Count);
        for (int i = 0; i < towers.Count; i++)
            PlayerPrefs.SetString("tower_" + i, towers[i].name);

        PlayerPrefs.Save();
    }

    public void Load()
    {
        towers.Clear();
        int count = PlayerPrefs.GetInt("count", 0);

        for (int i = 0; i < count; i++)
        {
            string name = PlayerPrefs.GetString("tower_" + i);
            TowerData t = Resources.Load<TowerData>("Towers/" + name);
            if (t != null) towers.Add(t);
        }
    }
}
