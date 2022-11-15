//Task 34
//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве. 

//Methods
/*
int [] CreateNewArray (int size, int minVal, int maxVal)    
    {
    int [] array = new int [size];
    for (int i=0; i<size; i++)
    {
        array[i]=new Random().Next(minVal, maxVal+1);
    }
    return array; 
    }
void ShowArray(int [] arr)
    {
    for (int i=0; i<arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
        Console.WriteLine();
    }
void CalcEvenOfArray(int [] arr)
    {
    ShowArray(arr);
    int count = 0;
    for(int i=0; i<arr.Length; i++)
        {
            
            if (arr[i]%2 == 0)
            {
                count++;
            }
        } 
        Console.WriteLine($"Your array have {count} even numbers");       
    }    
//Body
Console.WriteLine("Pls input Arrya size");
int array_size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Pls input min value of array");
int array_min_val = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Pls input max value of array");
int array_max_val = Convert.ToInt32(Console.ReadLine());
CalcEvenOfArray(CreateNewArray(array_size, array_min_val, array_max_val+1));
*/