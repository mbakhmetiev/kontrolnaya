//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

using System;

public class dz {
    public static void Main(string[] args) {
        const int sizei = 3;
        const int sizej = 4;
        int k = 0;
        string[,] arr = new string[sizei,sizej]{ {"Hello", "2", "world", ":-)"},
                                         {"1234", "1567", "-2", "computer science"},
                                         {"Russia", "Denmark", "Kazan", "Madagascar"} };

        string[] result = new string[sizei * sizej];

        for(int i = 0; i < sizei; i++) {
            for(int j = 0; j < sizej; j++) {
                if(arr[i,j].Length > 3)
                    continue;
                    else {    
                        result[k] = arr[i,j];
                        k++;
                    }
            }
        }

        string[] output = new string[k];

        for(int m = 0; m < output.Length; m++) {
            if(result[m] != "") {
                output[m] = result[m];
            }
        }

        Console.WriteLine("Массив из строк длиной <=3:");
        Console.Write("[");
        foreach(string item in output) {
            Console.Write($"\"{item}\", ");
        }
        Console.Write("]");
    }
}       
