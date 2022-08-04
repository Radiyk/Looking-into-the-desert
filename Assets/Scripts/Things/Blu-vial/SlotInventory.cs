using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotInventory : MonoBehaviour
{

    public Item SlotItem;

    public GameObject Play;
    BuffPlayer buffPlayer;
    Image icon;
    Button button;
   
    void Start()
    {
        icon = gameObject.transform.GetChild(0).GetComponent<Image>();
        button = GetComponent<Button>();
        button.onClick.AddListener(SlotClicked);
        buffPlayer = Play.GetComponent<BuffPlayer>();
    }

    public void PutInSlot(Item item)
    {
        icon.sprite = item.icon;
        SlotItem = item;
        icon.enabled = true;
    }

    private void SlotClicked()
    {
        if (SlotItem != null)
        {
            ClearSlot();
            buffPlayer.BluBuff();
        }
    }

    void ClearSlot()
    {
        icon.sprite = null;
        SlotItem = null;
    }
}
