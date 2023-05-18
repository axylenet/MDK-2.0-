// Вариант №5
//2. Дано предложение. Напечатать все слова, отличные от слова «Привет».

string text = Console.ReadLine();
string[] words = text.Split(' ');

foreach (string word in words)
{
    if (word != "Привет")
    {
        Console.Write(word + " ");
    }
}

// Пример ввода: Привет, как дела? Привет, нормально?
// Вывод: как дела? нормально?