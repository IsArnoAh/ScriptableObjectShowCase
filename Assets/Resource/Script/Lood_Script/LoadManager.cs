using UnityEngine;

public class LoadManager : MonoBehaviour
{
    // 模拟创建新开始所需参数
    private int leve=1;
    private float health=100;
    private Vector3 location = new Vector3(0, 0, 0);
    // ArchiveSTB声明
    public ArchiveSO archiveSo;
    
    // 新游戏，自动创建一个新存档
    public void NewGame()
    {
        LoadFile newLoadFile = new LoadFile(leve,health,location);
        archiveSo.loadFileList.Add(newLoadFile);
        Debug.Log("新游戏存档创建成功");
        
    }
    
    // 加载游戏，默认加载存档最新
    public void LoadGame()
    {
        // 检查是否有最新文档，没有则，创建新文档
        if (archiveSo.loadFileList.Count != 0)
        {
            Debug.Log("当前等级:" + archiveSo.loadFileList[^1].currentLevel);
            Debug.Log("当前血量:" + archiveSo.loadFileList[^1].currentHP);
            Debug.Log("当前位置:" + archiveSo.loadFileList[^1].location);
        }else NewGame();
    }
    
    // 删除存档,默认删除最后一条存档
    public void DelLoad()
    {
        // 判定是否有可用存档
        if (archiveSo.loadFileList.Count != 0)
        {
            archiveSo.loadFileList.RemoveAt(archiveSo.loadFileList.Count - 1);
        }
    }
    
    // 修改存档,默认修改最新存档等级使其变成Lv:10
    public void ModifyLoad()
    {
        archiveSo.loadFileList[^1].currentLevel = 10;
        Debug.Log("当前等级已修改成:"+archiveSo.loadFileList[^1].currentLevel);
    }
}
