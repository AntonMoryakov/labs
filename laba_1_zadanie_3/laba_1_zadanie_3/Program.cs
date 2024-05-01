using System;

class Program
{
    static void Main(string[] args)
    {
        // Создаем узлы дерева
        TreeNode root = new TreeNode(1);
        TreeNode node2 = new TreeNode(2);
        TreeNode node3 = new TreeNode(3);
        TreeNode node4 = new TreeNode(4);
        TreeNode node5 = new TreeNode(5);

        // Строим структуру дерева
        root.Children.Add(node2); // Добавляем в качестве потомков корневого узла node2 и node3
        root.Children.Add(node3);
        node2.Children.Add(node4); // Добавляем в качестве потомков узла node2 узел node4
        node3.Children.Add(node5); // Добавляем в качестве потомков узла node3 узел node5

        // Выводим значения потомков для каждого узла
        root.PrintChildrenValues();
    }
}