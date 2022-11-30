int[] CheckDirectionAndStartPozition(int N, int M)
{
    int[] arrayStartStopCorrect = new int[3]; ////третий элемент зарезервирован для булевой переменной корректности
    if (N < 0 & M < 0)
    {                              //Проверка возможных вариантов.1)оба числа отрицательных,N>M,N==M, начальное число отрицательное;
        Console.WriteLine("Числа отицательные, сумма элементов 0");
        arrayStartStopCorrect[2] = 1;
    }
    if (N < M)
    {
        arrayStartStopCorrect[0] = N;
        arrayStartStopCorrect[1] = M;
    }
    else
    {
        if (N == M)
        {
            Console.WriteLine("Числа одинаковые, сумма элементов 0");
            arrayStartStopCorrect[2] = 1;
        }
        else
        {
            arrayStartStopCorrect[0] = M;
            arrayStartStopCorrect[1] = N;
        }
    }
    if (arrayStartStopCorrect[0] < 0) arrayStartStopCorrect[0] = 0;
    return arrayStartStopCorrect;
}
int RecurseMethod(int start, int stop, int summElement)
{
    if (start <= stop)
    {
        summElement += start;
        start++;
        return RecurseMethod(start, stop, summElement);
    }
    return summElement;
}
int N = 15, M = 1; /// в условии сказано "задайте значения" я задал напрямую в коде
int start, stop;
int summElement = 0;
int[] tmpArray = CheckDirectionAndStartPozition(N, M);
if (tmpArray[2] == 0)
{
    start = tmpArray[0];
    stop = tmpArray[1];
    Console.WriteLine(RecurseMethod(start, stop, summElement));
}
/* по хорошему числа N и M необходимо проверить на дробность и округлить до ближайшего челого начало и до предыдущего целого  
конец. Тогда N и M изначально double, в методе проверка выполняем на отрицательность обоих чисел, определяем направление,
записываем во временный массив(или предворительно объявляем пару временных переменных) далее округляем  с помощью Math.Ceiling и Math.Floor.
затем эти значения проверяем на равенство и если все хорошо, передаем методу рекурсии. не стал включать в код, чтобы он небыл перегружен*/