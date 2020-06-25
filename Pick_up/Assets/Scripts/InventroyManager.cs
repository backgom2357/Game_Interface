using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventroyManager : MonoBehaviour {

    [SerializeField]
    Canvas inventoryPrefab;

    [SerializeField]
    Button itemPrefab;

    static string key = "i";

    private void Update()
    {
        Inventory();
    }

    public static List<string> inventory = new List<string>();

    void SpawnInventory()
    {
        Canvas inventoryCanvas = Instantiate<Canvas>(inventoryPrefab);
        SpawnItemButtons(inventoryCanvas);
    }

    void SpawnItemButtons(Canvas inven)
    {
        int count = 0;
        Vector3 inventoryPosition = inven.transform.position;
        foreach (string item in inventory)
        {
            count++;
            itemPrefab.GetComponentInChildren<Text>().text = item;
            Vector3 itemButtonPostion = new Vector3(inventoryPosition.x, inventoryPosition.y + 4 - count);
            Instantiate<Button>(itemPrefab, itemButtonPostion, Quaternion.identity, inven.transform);
        }
    }


    void Inventory()
    {
        if (GameManager.PressOnce(key))
        {
            if (GameObject.FindGameObjectWithTag("Inventory") == null)
            {
                SpawnInventory();
            }
            else
            {
                Destroy(GameObject.FindGameObjectWithTag("Inventory"));
            }
        }
    }

}
