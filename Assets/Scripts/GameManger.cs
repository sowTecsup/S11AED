using UnityEngine;

public class GameManger : MonoBehaviour
{
    private Tree<PlayerData> namesTree;
    void Start()
    {
        namesTree.TraverPreOrder(namesTree.Root, v => 
        {
            Debug.Log(v.SkillLevel);
            v.ClearData();
        });
    }

   
}

public class PlayerData
{
    public int SkillLevel;

    public void ClearData()
    {

    }
}
