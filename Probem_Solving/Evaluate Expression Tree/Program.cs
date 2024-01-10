namespace Evaluate_Expression_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Evaluate Expression Tree");
        }
        public class BinaryTree
        {
            public int value;
            public BinaryTree left = null;
            public BinaryTree right = null;

            public BinaryTree(int value)
            {
                this.value = value;
            }
        }

        public int EvaluateExpressionTree(BinaryTree tree)
        {
            // Write your code here.
            if (tree.left == null && tree.right == null)
                return tree.value;
            int left = EvaluateExpressionTree(tree.left);
            int right = EvaluateExpressionTree(tree.right);
            return ChooseOperation(left, right, tree.value);
        }

        public int ChooseOperation(int num1, int num2, int operand)
        {
            if (operand == -1)
                return num1 + num2;
            else if (operand == -2)
                return num1 - num2;
            else if (operand == -3)
                return num1 / num2;
            else if (operand == -4)
                return num1 * num2;
            return -1;
        }
    }
}