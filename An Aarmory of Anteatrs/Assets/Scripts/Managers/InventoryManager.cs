using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public InventorySlot[] inventorySlots;
    public GameObject inventoryItemPrefab;
    public bool AddPetr(Petr petr){
        //checks if there is any empty inventory space to add new petr
        //if there is not, this function does nothing but return false
        for(int i = 0; i < inventorySlots.Length; i++){
            InventorySlot slot = inventorySlots[i];
            InventoryItem item = slot.GetComponentInChildren<InventoryItem>();
            if(item == null){
                SpawnNewPetr(petr, slot);
                return true;
            }
        }
        return false;

    }

    private void SpawnNewPetr(Petr petr, InventorySlot slot){
        GameObject obj = Instantiate(inventoryItemPrefab, slot.transform);
        InventoryItem item = obj.GetComponent<InventoryItem>();
        item.SetPetr(petr);
    }
}
