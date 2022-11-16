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
// Задача 36: 
// Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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
void CalcNumberOnOddPosition(int [] arr)
    {
    ShowArray(arr);
    int sum=0;    
    for (int i=1; i<arr.Length; i=i+2)
        {
        sum=sum+arr[i];    
        }
    Console.WriteLine($"Your array have sum of odd element: {sum}"); 
    }
//Body
Console.WriteLine("Pls input Arrya size");
int array_size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Pls input min value of array");
int array_min_val = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Pls input max value of array");
int array_max_val = Convert.ToInt32(Console.ReadLine());
CalcNumberOnOddPosition(CreateNewArray(array_size, array_min_val, array_max_val));
*/

// Task 38
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. 

// Method
double [] CreateNewArray (int size, int minVal, int maxVal)    
    {
    double [] array = new double [size];
   
    for (int i=0; i<size; i++)
    {
        int num=(new Random().Next(minVal*10, maxVal*10+1));   // непонятно почему-то при попытке сразу делить... выдаёт int
        array[i]=Convert.ToDouble(num);
        array[i]=array[i]/10;  
    }
    return array; 
    }
void ShowArray(double [] arr)
    {
    for (int i=0; i<arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
        Console.WriteLine();
    }   
double FindMax(double [] arr)
    {
    double max =arr[0];
    for(int i=1; i<arr.Length;i++)
        {
            if(arr[i]>max)
                {
                    max=arr[i];            
                }
        }
              return max;    
    }    
double FindMin(double [] arr)
    {
    double min =arr[0];
    for(int i=1; i<arr.Length;i++)
        {
            if(arr[i]<min)
                {
                    min=arr[i];            
                }
        }  
    return min;
    }     
//Body
Console.WriteLine("Pls input Arrya size");
int array_size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Pls input min value of array");
int array_min_val = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Pls input max value of array");
int array_max_val = Convert.ToInt32(Console.ReadLine());
double [] our_array = CreateNewArray(array_size, array_min_val, array_max_val);
ShowArray(our_array);

Console.WriteLine($"Differense between max and min is {FindMax(our_array)} - {FindMin(our_array)}  ={FindMax(our_array)-FindMin(our_array)}");
