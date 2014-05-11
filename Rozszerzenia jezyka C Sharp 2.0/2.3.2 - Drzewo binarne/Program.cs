using System;
using System.Linq;

namespace DrzewoBinarne
{
    class Program
    {
        static void Main(string[] args)
        {
            //      9
            //    /   \
            //   8     7
            //  / \   / \
            // 6   5 4   3 
            //    / \
            //   2   1
            BinaryTreeNode<int> tree = 
                new BinaryTreeNode<int>(
                    new BinaryTreeNode<int>(
                        new BinaryTreeNode<int>(6),
                        8,
                        new BinaryTreeNode<int>(
                            new BinaryTreeNode<int>(2),
                            5,
                            new BinaryTreeNode<int>(1)
                        )
                    ),
                    9,
                    new BinaryTreeNode<int>(
                        new BinaryTreeNode<int>(4),
                        7,
                        new BinaryTreeNode<int>(3)
                    )
                );

            tree.ToList().ForEach(Console.WriteLine);
        }
    }
}
