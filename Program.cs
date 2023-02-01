
int[] Arr = new int[10];
Random rnd = new Random();

for (int i = 0; i < Arr.Length; i++)
{
    Arr[i] = rnd.Next(1, 10);//случайное число от 1 до 10
    Console.Write($"{Arr[i]} ");
}

Console.WriteLine("Минимальный элемент");
foreach (var n in Arr)
{
    var max = 0;
    if (n > max)
    {

    }
}

Console.ReadKey();



static void GetFibonschiSerial()
{
    bool repeat = true;

    while (repeat)
    {
        Console.WriteLine("Введите n");
        int n = Convert.ToInt32(Console.ReadLine());

        //int[] fib=new int[n];
        //fib[0] = 1;

        long pred = 0;
        long tek = 1;
        long fibonachi = 0;
        Console.WriteLine($"Шаг {1} = {pred}");
        Console.WriteLine($"Шаг {2} = {tek}");

        for (int i = 3; i <= n; i++)
        {
            fibonachi = pred + tek;
            Console.WriteLine($"Шаг {i} = {fibonachi:N0}");

            pred = tek; //на след. шаге сохраняем сумму в предыдущее значение
            tek = fibonachi; //сохраняем сумму в текущее значение
        }
        Console.WriteLine("Если хотите продолжить нажмите: д " +
                "Если нет любой символ и нажмите клавишу Enter");
        string go = Console.ReadLine();
        if (go.ToUpper() != "Д")
        {
            repeat = false;
        }
    }
}

