Console.WriteLine("Программа табулирует функцию y(x)=cos(x^2)+sin(x)^2 на отрезке [a, b] и шагом h. a,b и h вводите вы.");
string a = Console.ReadLine();
string b = Console.ReadLine();
string h = Console.ReadLine();
List<double> results = new List<double>(); //Создание списка, в который будут записываться результаты.
if (double.TryParse(a, out double aa) == false||double.TryParse(b, out double bb) == false||double.TryParse(h, out double hh) == false){
    Console.WriteLine("Вы должны ввести ЧИСЛА.");
}
else{
    Console.WriteLine("X | Y");
    double y;
    int swap = 0;
    for (double x = aa; x <= bb; x += hh){
        y = Math.Cos(Math.Pow(x, 2)) + Math.Pow(Math.Sin(x), 2);
        results.Add(y);
        Console.WriteLine($"{x} | {y}");
    }
    for (int i =0; i < results.Count - 1; i++){
        if ((Math.Sign(results[i]) == 1 && Math.Sign(results[i+1]) == -1)|| (Math.Sign(results[i]) == -1 && Math.Sign(results[i+1]) == 1)){
            swap += 1;
        }
    }
    Console.WriteLine($"Максимальное значение — {results.Max()}. Минимальное значение — {results.Min()}");
    Console.WriteLine($"Функция пересекает ось Х {swap} раз.");
}
