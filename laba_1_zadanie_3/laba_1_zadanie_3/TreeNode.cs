using System;
using System.Collections.Generic;

public class TreeNode
{
    // Значение узла
    public int Value { get; set; }

    // Список потомков узла
    public List<TreeNode> Children { get; set; }

    // Конструктор для создания узла с заданным значением
    public TreeNode(int value)
    {
        Value = value;
        Children = new List<TreeNode>(); // Инициализация списка потомков
    }

    // Метод для вывода на экран значений всех потомков текущего узла
    public void PrintChildrenValues()
    {
        Console.WriteLine($"Children of node with value {Value}:"); // Выводим сообщение о потомках текущего узла
        foreach (var child in Children)
        {
            Console.WriteLine(child.Value); // Выводим значение текущего потомка
            child.PrintChildrenValuesRecursive(); // Рекурсивно вызываем метод для вывода значений потомков текущего потомка
        }
    }

    // Рекурсивный метод для вывода на экран значений всех потомков узла
    private void PrintChildrenValuesRecursive()
    {
        foreach (var child in Children)
        {
            Console.WriteLine(child.Value); // Выводим значение текущего потомка
            child.PrintChildrenValuesRecursive(); // Рекурсивно вызываем метод для вывода значений потомков текущего потомка
        }
    }
}