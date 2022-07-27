// Лекция № 7. Основы программирования

// Вывести все целые числа от a до b, a <= b
string NumberRec(int a, int b)
{
    if (a < b) return $"{a} " + NumberRec(a + 1, b);
    else return $"{b}";
}

// Console.WriteLine(NumberRec(1, 10));

// Факториал числа
int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= i;
    }
    return result;
}

int FactorialRec(int n)
{
    if (n == 1) return 1;
    else return n * FactorialRec(n - 1);
}

// Console.WriteLine(FactorialRec(10));
// Console.WriteLine(FactorialFor(10));

// Возвести a в степень n
int PowerRec(int a, int n)
{
    return n == 0 ? 1 : PowerRec(a, n - 1) * a;
    //if (n == 0) return 1;
    //else return PowerRec(a, n - 1) * a;
}

// Console.WriteLine(PowerRec(2, 10));

// Перебор слов
int n = 1;
void FindWordsRec(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWordsRec(alphabet, word, length + 1);
    }
}

// FindWordsRec("аисв", new char[4]);