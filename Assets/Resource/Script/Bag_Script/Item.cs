using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    // 公开基本物品参数,
    public Image itemIcon;
    public Text itemName;
    public string itemInfo;
    public bool isEquipment;

    // 展示面板信息绑定
    public Image showIcon;
    public Text showInfo;
    public Text showTip;
    
    // 更新信息面板函数
    public void UpdateInfoPanel()
    {
        showIcon.sprite = itemIcon.sprite;
        showInfo.text = itemInfo;
        showTip.text = isEquipment ? "装备" : "使用";
    }
}
