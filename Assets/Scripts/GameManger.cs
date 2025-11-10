using UnityEngine;

public class GameManger : MonoBehaviour
{
    private Tree<string> namesTree;

    BinaryTree<int> rootBinaryTree = new(8);
    void Start()
    {
        /*string tarversePre = "";
        namesTree.TraversePreOrder(namesTree.Root, v => 
        {
         tarversePre += v + ", ";
        });
        print(tarversePre);*/





        rootBinaryTree.AddChild(8, 3, true);
        rootBinaryTree.AddChild(8, 10, false);

        rootBinaryTree.AddChild(3, 1, true);
        rootBinaryTree.AddChild(3, 6, false);

        rootBinaryTree.AddChild(6, 4, true);
        rootBinaryTree.AddChild(6, 7, false);


        rootBinaryTree.AddChild(10, 14);

        rootBinaryTree.AddChild(14, 13);

        rootBinaryTree.TraverseInOrder(rootBinaryTree.Root, v => Debug.Log(v));


    }

   
}

