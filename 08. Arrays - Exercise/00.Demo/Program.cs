// 1. Write a C# Sharp program that stores elements in an array and prints them.
//int[] numbers = new int[10];

//for (int i = 0; i < numbers.Length; i++)
//{
//    numbers[i] = int.Parse(Console.ReadLine());
//}
//Console.WriteLine(string.Join(" ", numbers));


// 2. Write a C# Sharp program to read n values in an array and display them in reverse order.
//int[] numbers = new int[3] { 2, 5, 7 };
//for (int i = numbers.Length - 1; i >= 0; i--)
//{
//    Console.Write($"{numbers[i]} ");
//}


// 3. Write a program in C# Sharp to find the sum of all array elements.
//int[] numbers = new int[3] { 2, 5, 8 };
//int sum = 0;
//foreach (var number in numbers)
//{ 
//    sum += number;
//}
//Console.WriteLine(sum);


//4. Write a C# Sharp program to copy the elements of one array into another array.
//int[] numbers = new int[3] {15, 10, 12 };
//int[] arrayTwo = new int[3];

//for (int i = 0; i < numbers.Length; i++)
//{ 
//    arrayTwo[i] = numbers[i];   
//}
//Console.WriteLine($"The elements are: {(string.Join(" ", arrayTwo))}");


//5. Write a C# Sharp program in to count duplicate elements in an array.
//int[] numbers = new int[8] { 1, 5, 1, 6 , 7 , 8 , 0, 3 };
//for (int i = 0; i < numbers.Length; i++)
//{
//    for (int j = i + 1; j < numbers.Length; j++)
//    {
//        if (numbers[i] == numbers[j])
//        {
//            Console.WriteLine(numbers[i]);
//            //Console.WriteLine($"The element at index: {i} is {numbers[i]} and the element at index: {j} is again {numbers[j]} ");
//        }
//    }
//}


//6. Write a program in C# Sharp to print all unique elements in an array.
//int[] numbers = new int[3] { 1, 1, 5 };
//for (int i = 0; i < numbers.Length; i++)
//{
//    for (int j = i + 1; j < numbers.Length; j++)
//    {
//        if (numbers[i] != numbers[j])
//        {
//            Console.WriteLine(numbers[j]);
//            break;
//        }
//    }
//    break;
//}


//7. Write a C# Sharp program to merge two arrays of the same size sorted in ascending order.
//int[] numbers = new int[3] { 1, 2, 3 };
//int[] numbers2 = new int[3] { 1, 2, 3 };
//int[] combined = new int[6];

//for (int i = 0; i < numbers.Length; i++)
//{
//    combined[2 * i] = numbers[i];
//    combined[2 * i + 1] = numbers2[i];
//}
//Console.WriteLine(string.Join(" ", combined));



//8. Write a C# Sharp program to count the frequency of each element in an array.
//int[] numbers = new int[3] { 25, 12, 43 };
//int count = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//    int currentVallue = numbers[i];
//    for (int j = 0; j < numbers.Length; j++)
//    {
//        if (currentVallue == numbers[j])
//        { 
//            count++;
//        }
//    }
//    Console.WriteLine($"{currentVallue} occurs {count} times");
//    count = 0;
//}



//9. Write a C# Sharp program to find the maximum and minimum elements in an array.
//int[] numbers = new int[3] { 45, 25, 21 };
//int max = int.MinValue;
//int min = int.MaxValue;
//for (int i = 0; i < numbers.Length; i++)
//{
//    int currentElement = numbers[i];
//    for (int j = 0; j < numbers.Length; j++)
//    {
//        if (currentElement >= max)
//        {
//            max = currentElement;
//        }
//    }
//    for (int j = 0; j < numbers.Length; j++)
//    {
//        if (currentElement <= min)
//        {
//            min = currentElement;
//        }
//    }
//}
//Console.WriteLine($"Maximum element is : {max}");
//Console.WriteLine($"Minimum element is : {min}");



//10. Write a program in C# Sharp to separate odd and even integers into separate arrays.
//int[] numbers = new int[5] { 25, 47, 42, 56, 32 };
//int evenNums = 0;
//int oddNums = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] % 2 == 0)
//    {
//        evenNums++;
//    }
//    else
//    {
//        oddNums++;
//    }
//}
//int[] evenNumbers = new int[evenNums];  // 42 56 32
//int[] oddNumbers = new int[oddNums];    // 25 47

//int evenIndex = 0;
//int oddIndex  = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    int currentValue = numbers[i];
//    if (currentValue % 2 == 0)
//    {
//        evenNumbers[evenIndex] = currentValue;
//        evenIndex++; 
//    }
//    else
//    {
//        oddNumbers[oddIndex] = currentValue;
//        oddIndex++; 
//    }
//}
//Console.WriteLine($"The Even elements are: {(string.Join(" ", evenNumbers))}");
//Console.WriteLine($"The Odd elements are: {(string.Join(" ", oddNumbers))}");



//11. Write a C# Sharp program to sort elements of an array in ascending order.
//using System.Drawing;

//int[] numbers = new int[5] { 2, 7, 4, 5, 9 };
//int[] ascending = new int[numbers.Length];
//Array.Sort(numbers);
//Console.WriteLine(string.Join(" ", numbers));
//Array.Reverse(numbers);
//Console.WriteLine(string.Join(" ", numbers));



/* 12.. Да се напише програма, която създава масив с 20 елемента от целочислен тип
и инициализира всеки от елементите със стойност равна на индекса на елемента умножен по 5.
Елементите на масива да се изведат на конзолата.*/
//int[] numbers = new int[20] { 1, 0, 8, 43, 12, 101, 7, 94, 13, 64, 666, 4, 101, 147, 1547, 132, 1021, 7, 98, 14321 };
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine($"{numbers[i] * 5}");
//}




/* 13. Да се напише програма, която чете два масива от конзолата и прове­рява дали са еднакви.*/
//string[] arrayOne = new string [5] {"wow", "how", "bow", "pow", "row"};
////string[] arrayTwo = new string[5] { "wow", "how", "bow", "pow", "row" };
//string[] arrayTwo = new string[5] { "wow", "flow", "throw", "pow", "row" };
//bool isTheSame = false;
//for (int i = 0; i < arrayOne.Length; i++)
//{
//    if (arrayOne[i] == arrayTwo[i])
//    {
//        isTheSame = true;
//        //Console.WriteLine($"Both elements at index: {i} in the two arrays are the same: {arrayTwo[i]}");
//    }
//    else
//    {
//        isTheSame = false;
//        //Console.WriteLine($"Element at index: {i} in arrayOne is: {arrayOne[i]} and in arrayTwo is: {arrayTwo[i]}");
//    }
//}
//if (isTheSame)
//{
//    Console.WriteLine($"Arrays are the same");
//}
//else
//{
//    Console.WriteLine($"Arrays are NOT the same");
//}



//13. Да се напише програма, която сравнява два масива от тип char лексикографски (буква по буква)
//и проверява кой от двата е по-рано в лексикографската подредба.
//char[] array1 = new char[5] { 'a', 'b', 'c', 'd', 'e'};
//char[] array2 = new char[5] { 'a', 'b', 'c', 'd', 'e'};
//bool isTheSame = false;
//for (int i = 0; i < array1.Length; i++)
//{
//    if (array1[i] == array2[i])
//    {
//        isTheSame = true;
//    }
//    else
//    {
//        isTheSame = false;
//    }
//}
//if (isTheSame)
//{
//    Console.WriteLine("Same");
//}



//14.  Напишете програма, която намира максимална редица от последова­телни еднакви елементи в масив.
//Пример: { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1} => {2, 2, 2}.

//int[] numbers = Console.ReadLine()
//               .Split()
//               .Select(int.Parse)
//               .ToArray();
//int bestLength = 1;       // Най-дълга поредица
//int currentLength = 1;    // Текуща дължина на поредицата
//int bestIndex = numbers[0];  // Число с най-дълга поредица
//for (int i = 0; i < numbers.Length - 1; i++)
//{
//    if (numbers[i] == numbers[i + 1])
//    {
//        currentLength++;
//    }
//    else
//    {
//        currentLength = 1;
//    }
//    // Ако намерим нова най-дълга поредица
//    if (currentLength > bestLength)
//    {
//        bestLength = currentLength;
//        bestIndex = numbers[i];
//    }
//}
//// Отпечатване на числото, повторено най-дългия брой пъти
//for (int i = 0; i < bestLength; i++)
//{
//    Console.Write(bestIndex + " ");
//}



//15. Напишете програма, която намира максималната редица от последова­телни нараст­ващи елементи в масив.
//Пример: { 3 2 3 4 2 2 4} => {2, 3, 4}

//int[] numbers = Console.ReadLine()
//           .Split()
//           .Select(int.Parse)
//           .ToArray();

//int bestLength = 1;             // Най-дълга поредица
//int currentLength = 1;          // Текуща дължина на поредицата
//int bestStartIndex = 0;         // Начален индекс на най-дълга поредица
//int currentStartIndex = 0;      // Начален индекс на текуща поредица

//for (int i = 0; i < numbers.Length - 1; i++)
//{
//    if (numbers[i] < numbers[i + 1])
//    {
//        currentLength++;
//    }
//    else
//    {
//        currentLength = 1;
//        currentStartIndex = i + 1; // Започваме нова поредица от следващия елемент
//    }

//    // Ако намерим нова най-дълга поредица
//    if (currentLength > bestLength)
//    {
//        bestLength = currentLength;
//        bestStartIndex = currentStartIndex;
//    }
//}

//// Отпечатване на най-дългата нарастваща поредица
//Console.WriteLine("Най-дългата нарастваща поредица е:");
//for (int i = bestStartIndex; i < bestStartIndex + bestLength; i++)
//{
//    Console.Write(numbers[i] + " ");
//}



//16.