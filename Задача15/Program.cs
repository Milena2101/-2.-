// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.WriteLine("Введите день недели в виде числа: ");
int day = Convert.ToInt32(Console.ReadLine());
if(day >=1 && day <=7)
{
    if (day == 6 || day == 7) 
    Console.WriteLine("Ура, выходной");
    else
    {
        Console.WriteLine("Нет, это будничный день");
    }
}
else
{
    Console.WriteLine("Введенно не то значение");
}