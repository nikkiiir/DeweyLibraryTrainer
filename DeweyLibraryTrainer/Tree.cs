using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DeweyLibraryTrainer.NodeTree;

namespace DeweyLibraryTrainer
{
    public class Tree<T>
    {
        private Stack<TreeNode<T>> stack = new Stack<TreeNode<T>>();

        public List<TreeNode<T>> TreeNodes { get; } = new List<TreeNode<T>>();

        public Tree<T> Begin(T value)
        {
            if (stack.Count == 0)
            {
                TreeNode<T> nodeT = new TreeNode<T>(value, null);
                TreeNodes.Add(nodeT);
                stack.Push(nodeT);
            }
            else
            {
                TreeNode<T> nodeT = stack.Peek().Add(value);
                stack.Push(nodeT);
            }

            return this;
        }

        public Tree<T> Add(T value)
        {
            stack.Peek().Add(value); // Views the first element in the Stack but does not remove it.
            return this;
        }

        public Tree<T> End()
        {
            stack.Pop(); // Removes another element from the Stack.
            return this;
        }
    }
}
