//int totalPairs = int.Parse(Console.ReadLine());
//int firstDigit = 0;
//int secondDigit = 0;
//int thirdDigit = 0;

//for (int pair = 1; pair <= totalPairs; pair++)
//{ 
//    int input = int.Parse(Console.ReadLine());
//    int inputCopy = input;
//    if (input > 99 && input < 1000)
//    {

//        thirdDigit = input % 10;
//        input /= 10;
//        secondDigit = input % 10;
//        input /= 10;
//        firstDigit = input;


//    }
//    else if (input > 9 && input < 100)
//    {
//        // 2 digit  75
//        firstDigit = input / 10;
//        secondDigit = input % 10;
//        switch (firstDigit)
//        {
//            case 0: Console.Write(" "); break;
//            case 2: Console.Write("a"); break;
//            case 3: Console.Write("d"); break;
//            case 4: Console.Write("g"); break;
//            case 5: Console.Write("j"); break;
//            case 6: Console.Write("m"); break;
//            case 7: Console.Write("p"); break;
//            case 8: Console.Write("t"); break;
//            case 9: Console.Write("w"); break;
//        }
//        switch (secondDigit)
//        {
//            case 0: Console.Write(" "); break;
//            case 2: Console.Write("b"); break;
//            case 3: Console.Write("e"); break;
//            case 4: Console.Write("h"); break;
//            case 5: Console.Write("k"); break;
//            case 6: Console.Write("n"); break;
//            case 7: Console.Write("q"); break;
//            case 8: Console.Write("u"); break;
//            case 9: Console.Write("x"); break;
//        }
//    }
//    else 
//    {
//        firstDigit = input ;
//        switch (firstDigit) 
//        {
//            case 0: Console.Write(" "); break;
//            case 2: Console.Write("a"); break;
//            case 3: Console.Write("d"); break;
//            case 4: Console.Write("g"); break;
//            case 5: Console.Write("j"); break;
//            case 6: Console.Write("m"); break;
//            case 7: Console.Write("p"); break;
//            case 8: Console.Write("t"); break;
//            case 9: Console.Write("w"); break;
//        }
//    }
//    //Console.WriteLine();


//}
////Console.WriteLine(firstDigit);
///








//int totalPairs = int.Parse(Console.ReadLine());
//int firstDigit = 0, secondDigit = 0, thirdDigit = 0;

//for (int pair = 1; pair <= totalPairs; pair++)
//{
//    int input = int.Parse(Console.ReadLine());

//    if (input > 99 && input < 1000) // Ако е трицифрено число
//    {
//        thirdDigit = input % 10;
//        input /= 10;
//        secondDigit = input % 10;
//        input /= 10;
//        firstDigit = input;

//        // Обработваме всяка цифра поотделно
//        ProcessDigit(firstDigit);
//        ProcessDigit(secondDigit);
//        ProcessDigit(thirdDigit);
//    }
//    else if (input > 9 && input < 100) // Ако е двуцифрено число
//    {
//        secondDigit = input % 10;
//        firstDigit = input / 10;

//        ProcessDigit(firstDigit);
//        ProcessDigit(secondDigit);
//    }
//    else // Ако е едноцифрено число
//    {
//        firstDigit = input;
//        ProcessDigit(firstDigit);
//    }
//}

//// Функция за обработка на всяка цифра от клавиатурата
//void ProcessDigit(int digit)
//{
//    switch (digit)
//    {
//        case 0: Console.Write(" "); break;
//        case 2: Console.Write("a"); break;
//        case 22: Console.Write("b"); break;
//        case 222: Console.Write("c"); break;
//        case 3: Console.Write("d"); break;
//        case 33: Console.Write("e"); break;
//        case 333: Console.Write("f"); break;
//        case 4: Console.Write("g"); break;
//        case 44: Console.Write("h"); break;
//        case 444: Console.Write("pair"); break;
//        case 5: Console.Write("j"); break;
//        case 55: Console.Write("k"); break;
//        case 555: Console.Write("l"); break;
//        case 6: Console.Write("m"); break;
//        case 66: Console.Write("n"); break;
//        case 666: Console.Write("o"); break;
//        case 7: Console.Write("p"); break;
//        case 77: Console.Write("q"); break;
//        case 777: Console.Write("r"); break;
//        case 7777: Console.Write("s"); break;
//        case 8: Console.Write("t"); break;
//        case 88: Console.Write("u"); break;
//        case 888: Console.Write("v"); break;
//        case 9: Console.Write("w"); break;
//        case 99: Console.Write("x"); break;
//        case 999: Console.Write("y"); break;
//        case 9999: Console.Write("z"); break;
//        default: break;
//    }
//}


int totalPairs = int.Parse(Console.ReadLine());

for (int pair = 1; pair <= totalPairs; pair++)
{
    int letter = int.Parse(Console.ReadLine());
    switch (letter)
    {
        case 0: Console.Write(" "); break;
        case 2: Console.Write("a"); break;
        case 22: Console.Write("b"); break;
        case 222: Console.Write("c"); break;
        case 3: Console.Write("d"); break;
        case 33: Console.Write("e"); break;
        case 333: Console.Write("f"); break;
        case 4: Console.Write("g"); break;
        case 44: Console.Write("h"); break;
        case 444: Console.Write("i"); break;
        case 5: Console.Write("j"); break;
        case 55: Console.Write("k"); break;
        case 555: Console.Write("l"); break;
        case 6: Console.Write("m"); break;
        case 66: Console.Write("n"); break;
        case 666: Console.Write("o"); break;
        case 7: Console.Write("p"); break;
        case 77: Console.Write("q"); break;
        case 777: Console.Write("r"); break;
        case 7777: Console.Write("s"); break;
        case 8: Console.Write("t"); break;
        case 88: Console.Write("u"); break;
        case 888: Console.Write("v"); break;
        case 9: Console.Write("w"); break;
        case 99: Console.Write("x"); break;
        case 999: Console.Write("y"); break;
        case 9999: Console.Write("z"); break;
        default: break;
    }
}
