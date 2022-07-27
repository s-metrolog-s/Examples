// Игра Ханойские башни
// http://rebus1.com/index.php?item=tower

void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}

// Towers();

// Обход бинарного дерева
// ((4 - 2) * (1 + 3)) / 10

string emp = String.Empty;
string[] tree = {emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };

void InOrderTraversal (int pos = 1)
{
    if (pos < tree.Length)
    {
        int left = 2 * pos; // Указание позиции в дереве (массиве)
        int right = 2 * pos + 1;
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        Console.WriteLine(tree[pos]);
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
        }
}

// InOrderTraversal();