using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeweyLibraryTrainer
{
    public class NodeTree
    {

        public class TreeNode<T>
        {
            public T Value { get; }
            public TreeNode<T> Parent { get; }
            public List<TreeNode<T>> Children { get; }

            public TreeNode(T value, TreeNode<T> parent)
            {
                Value = value;
                Parent = parent;
                Children = new List<TreeNode<T>>();
            }

            public TreeNode<T> Add(T value)
            {
                TreeNode<T> nodeT = new TreeNode<T>(value, this);
                Children.Add(nodeT);
                return nodeT;
            }
        }
    }
}
