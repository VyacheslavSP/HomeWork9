int AckermanFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return AckermanFunc(m - 1, 1);
    }
    else
    {
        return AckermanFunc(m - 1, AckermanFunc(m, n - 1));
    }
}
int m = 3, n = 2;
Console.WriteLine(AckermanFunc(m, n));
/* 
Насколько я понял с просторов интернета, в современной .Net данная ошибка (переполнение стека) ловится автоматически и принудительно убивает
процесс. Однако  до .NET Framework 2. это можно было делать через обычные try-catch. К сожалению, попытка поставить
ранний Net на компьютер не увенчалась успехом поэтому дальше код теоритический
17  try
18  {
19      Console.WriteLine(AckermanFunc(m, n));
20  }
21  catch
22  {
23     Console.WriteLine("hyper(2,"+m+","+n+"+3)-3");
24  }

*/