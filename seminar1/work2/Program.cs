Console.WriteLine("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int count = -num;
if (num > 0)
{
    while (count < num)
    {
        Console.Write(count + " ");
        count++;
    }
}
else
{
    Console.WriteLine("Ошибка ввода! Введите целоположительное число!");

}