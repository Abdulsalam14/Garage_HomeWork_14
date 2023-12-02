
PrintText("Hello World!");

void PrintText(string text)
{
    foreach (var ch in text)
    {
        Console.Write(ch);
        Thread.Sleep(800);
    }
}
