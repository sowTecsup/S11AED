using UnityEngine;

public class GameManager : MonoBehaviour
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





        rootBinaryTree.AddChild(8, 1, true);
        rootBinaryTree.AddChild(8, 5, false);

        rootBinaryTree.AddChild(1, 7, false);

        rootBinaryTree.AddChild(7, 10, false);

        rootBinaryTree.AddChild(5, 10, true);
        rootBinaryTree.AddChild(5, 6, false);

        rootBinaryTree.AddChild(10, 4, true);


        rootBinaryTree.TraverseInOrder(rootBinaryTree.Root, v => Debug.Log(v));


    }

   
}

