using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BagItemsData", menuName = "BagItems/BagItem", order = 2)]
public class BagItemsSO : ScriptableObject
{
    public List<BagItem> bagItemList = new List<BagItem>();
}

// 背包物品类，用于定义背包物品的基本属性，其中这里演示包含所需的图标、是否为装备
[System.Serializable]
public class BagItem
{
    public Sprite itemIcon;
    public string itemName;
    [TextArea]
    public String itemInfo;
    public bool isEquipment;
}