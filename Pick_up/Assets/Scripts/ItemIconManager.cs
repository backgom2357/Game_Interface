using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemIconManager : MonoBehaviour {

    public void SpawnTheItem()
    {
        GameObject item;
        string name = GetComponentInChildren<Text>().text;
        item = (GameObject)Resources.Load("Temp/" + name, typeof(GameObject));
        Instantiate<GameObject>(item, GameObject.Find("bear").transform.position, Quaternion.identity).name = name;
        System.IO.File.Delete(@"C:\Users\backg\Documents\PickUp\Assets\Resources\Temp\" + name + ".prefab");
        InventroyManager.inventory.Remove(name);
        Destroy(gameObject);
        
    }

}
