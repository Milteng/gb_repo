/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class Task {
    //функция генерации случайного числа
    public static int generateRandInt(int minValue, int maxValue)
    {
            Random r = new Random();
            return r.Next(minValue, maxValue);
    }
    
    
  static void Main() {
     
    
    
    //Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
    //и возвращает значение этого элемента или же указание, что такого элемента нет.
    Console.WriteLine("Задача 1-------------------------------------------------");
    Console.WriteLine("Введите количество строк массива");
    int lines = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов массива");
    int columns = int.Parse(Console.ReadLine());
    
    
    int[,] Array1 = new int[lines, columns];
    
    for (int i = 0; i < Array1.GetLength(0); i++){
        
         for (int j = 0; j < Array1.GetLength(1); j++)
             Array1[i,j] = generateRandInt(1,100); 
        
    }
    
    string s = "";
    //выведем массив
    for (int i = 0; i < Array1.GetLength(0); i++){
        s = "";
         for (int j = 0; j < Array1.GetLength(1); j++)
             s = s+ Array1[i,j]+" ";
                
        Console.WriteLine(s);
    }
    
    
    Console.WriteLine("Введите позиции двумерного массива");
    lines = int.Parse(Console.ReadLine());
    columns = int.Parse(Console.ReadLine());
    
    if (lines<0 || lines>=Array1.GetLength(0))
      Console.WriteLine("Введен неверный номер строки");
    else
    if (columns<0 || columns>=Array1.GetLength(1))
       Console.WriteLine("Введен неверный номер столбца"); 
    else
       Console.WriteLine($"Элемент массива {Array1[lines,columns]}"); 
       
       
       
       
    //Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.   
    Console.WriteLine("Задача 2-------------------------------------------------"); 
    int temp;
    for (int i = 0; i < Array1.GetLength(1); i++){
       temp = Array1[0,i];
       Array1[0,i] =Array1[Array1.GetLength(0)-1,i];
       Array1[Array1.GetLength(0)-1,i] = temp;
    }    
    
    for (int i = 0; i < Array1.GetLength(0); i++){
        s = "";
         for (int j = 0; j < Array1.GetLength(1); j++)
             s = s+ Array1[i,j]+" ";
                
        Console.WriteLine(s);
    }
    
    
    
    //Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
    Console.WriteLine("Задача 3-------------------------------------------------"); 
    int[,] Array2 = new int[4, 4];
    int m = 0;
    int m_temp = 0;
    int index_m = 0;
    
    for (int i = 0; i < Array2.GetLength(0); i++){
        
         for (int j = 0; j < Array2.GetLength(1); j++)
             Array2[i,j] = generateRandInt(1,100); 
        
    }
    
    //выведем массив
    for (int i = 0; i < Array2.GetLength(0); i++){
        s = "";
         for (int j = 0; j < Array2.GetLength(1); j++)
             s = s+ Array2[i,j]+" ";
                
        Console.WriteLine(s);
    }
    
    
    //найдем сумму первой строки
    for (int i = 0; i < Array2.GetLength(1); i++){
        m = m + Array2[0,i];
    }     
    
    
    for (int i = 1; i < Array2.GetLength(0); i++){
         m_temp = 0;
         for (int j = 0; j < Array2.GetLength(1); j++)
             m_temp = m_temp+Array2[i,j];
               
         if (m_temp<m) {
            m = m_temp;
            index_m = i;
         }        
        
        
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов {index_m}");
    
    
  }
  
}
