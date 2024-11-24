using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        
        Random random = new Random();
        List<int> numbers = Enumerable.Range(1, 10).Select(_ => random.Next(-50, 50)).ToList();
        
        Console.WriteLine("Orijinal Liste: " + string.Join(", ", numbers));
        
        var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
        Console.WriteLine("Çift Sayılar: " + string.Join(", ", evenNumbers));
        
        var oddNumbers = numbers.Where(n => n % 2 != 0).ToList();
        Console.WriteLine("Tek Sayılar: " + string.Join(", ", oddNumbers));
        
        var negativeNumbers = numbers.Where(n => n < 0).ToList();
        Console.WriteLine("Negatif Sayılar: " + string.Join(", ", negativeNumbers));
        
        var positiveNumbers = numbers.Where(n => n > 0).ToList();
        Console.WriteLine("Pozitif Sayılar: " + string.Join(", ", positiveNumbers));

       
        var rangeNumbers = numbers.Where(n => n > 15 && n < 22).ToList();
        Console.WriteLine("15'ten büyük ve 22'den küçük Sayılar: " + string.Join(", ", rangeNumbers));
        
        var squaredNumbers = numbers.Select(n => n * n).ToList();
        Console.WriteLine("Her Sayının Karesi: " + string.Join(", ", squaredNumbers));
    }
}