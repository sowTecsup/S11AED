using UnityEngine;

public class GameManger : MonoBehaviour
{
    private Tree<string> namesTree;
    void Start()
    {
        namesTree.TraverPreOrder(namesTree.Root, v => 
        {
            Debug.Log(v);
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
