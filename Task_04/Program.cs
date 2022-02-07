// Найти максимальное из трёх чисел.

int a = 3;
int b = 10;
int c = 19;

int max = a;

if (max < a) max = a;
if (max < b) max = b;
if (max < c) max = c;

Console.Write("Максимальное число равно ");
Console.WriteLine(max);