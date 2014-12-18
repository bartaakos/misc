using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using snipd;

namespace binarytree
{
    class RecoverableBST<T> : BinarySearchTree<T>
    {
        public string getArchivedText(TreeNode<T> node)
        {
            string archive = "";

            if (node != null)
            {   
                archive += node.Element + ";" + getArchivedText(node.Left) + getArchivedText(node.Right);
            }

            return archive;
        }

        public void restoreTree(string archive)
        {
            MakeEmpty();

            string[] nodes = archive.Split(';');

            foreach (string node in nodes)
            {
                try
                {
                    if (node.Length > 0)
                    {
                        T n = (T)Convert.ChangeType(node, typeof(T));
                        Insert(n);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("PARSING ERROR");
                    throw;
                }
                
            }
        }
    }
}
