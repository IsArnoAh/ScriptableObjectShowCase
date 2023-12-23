using System.Collections.Generic;
using UnityEngine;

// 声明使用CreateAssetMenu，之后我们会在右键创建菜单栏里实例出ArchiveSTB,其实例结构默认名字为fileName指定的名字
[CreateAssetMenu(fileName = "LoadData", menuName = "Load/LoadFiles", order = 1)]
public class ArchiveSO : ScriptableObject
{
    // 存档通常以多个存档形式存在，而这里我们使用list对其进行填充
    public List<LoadFile> loadFileList = new List<LoadFile>();
}

/// 假定LoadFile为游戏存档所需的基本信息，使其序列化，这能更好进行手动添加或者移除所实例出来的对象
[System.Serializable]
public class LoadFile
{
    // 游戏存档所需的基本配置，这里模拟当前等级，血量，和位置
    public int currentLevel;
    public float currentHP;
    public Vector3 location;

    // 自定义构造函数
    public LoadFile(int currentLevel, float currentHp, Vector3 location)
    {
        this.currentLevel = currentLevel;
        currentHP = currentHp;
        this.location = location;
    }
}