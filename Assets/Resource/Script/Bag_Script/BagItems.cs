using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagItems : MonoBehaviour
{
    public BagItemsSO bagItemsSo;
    private Item _itemScript;
    private void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            _itemScript = transform.GetChild(i).GetComponent<Item>();
            _itemScript.itemIcon.sprite = bagItemsSo.bagItemList[i].itemIcon;
            _itemScript.itemName.text = bagItemsSo.bagItemList[i].itemName;
            _itemScript.itemInfo = bagItemsSo.bagItemList[i].itemInfo;
            _itemScript.isEquipment = bagItemsSo.bagItemList[i].isEquipment;
        }
    }
}
