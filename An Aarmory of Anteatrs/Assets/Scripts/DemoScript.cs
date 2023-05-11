using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoScript : MonoBehaviour
{
    public InventoryManager inventory;
    public Petr[] petrsToAdd;

    public void AddPetrToInventory(int index){
        Petr petrToAdd = petrsToAdd[index];
        bool res = inventory.AddPetr(petrToAdd);
        if(res){
            Debug.Log("Petr added to inventory");
        }else{
            Debug.Log("Petr NOT ADDED to inventory");
        }

    }
}
