using UnityEngine;

public class GameManger : MonoBehaviour
{
    private Tree<string> namesTree;
    void Start()
    {
        string tarversePre = "";
        namesTree.TraversePreOrder(namesTree.Root, v => 
        {
         tarversePre += v + ", ";
        });
        print(tarversePre);
    }

   
}

public class PlayerData
{
    public int SkillLevel;

    public void ClearData()
    {

    }
}
