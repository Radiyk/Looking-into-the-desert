using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public static Inventory instance;
    public Transform SlotsParent;

    public SlotInventory[] inventorySlots = new SlotInventory[3];

    void Start()
    {
        instance = this;
        for (int i = 0; i < inventorySlots.Length; i++)
        {
            inventorySlots[i] = SlotsParent.GetChild(i).GetComponent<SlotInventory>();
        }

       
    }

    public void PutInEmptySlot(Item item)
    {
        for (int i = 0; i < inventorySlots.Length; i++)
        {
            if (inventorySlots[i].SlotItem == null)
            {
                inventorySlots[i].PutInSlot(item);
                return;
            }
        }
    }
}
