void printNumbers(byte count)
{
    if(count==1){
 Console.Write("1"+'"');       
    }
    else{
        Console.Write(count+", ");
        printNumbers((byte)(count-1));
    }
}
byte count;
Console.WriteLine("Введите число от 1 до 255"); /// искуственное ограничение, чтобы не вызывать переполнение стека и не пытаться его отслеживать
try{
    count=Convert.ToByte(Console.ReadLine());
    if (count==0){
       throw new Exception("Некорректный ввод числа");
    }

    Console.Write('"');
    printNumbers(count);
}
catch{
    Console.WriteLine("Некорректный ввод числа");
}


