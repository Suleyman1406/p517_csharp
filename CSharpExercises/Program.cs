
//int[] findElementsAboveLimit(int[] numbers, int limit)
//{
//    int count = 0;
//    for (int i = 0; i < numbers.Length; i++)
//    {
//        if (numbers[i] > limit)
//        {
//            count += 1;
//        }
//    }

//    int[] filteredNumbers = new int[count];
//    int lastFilledIdx = 0;

//    for (int i = 0; i < numbers.Length; i++)
//    {
//        if (numbers[i] > limit)
//        {
//            filteredNumbers[lastFilledIdx] = numbers[i];
//            lastFilledIdx += 1;
//        }
//    }

//    return filteredNumbers;
//}

//int[] filteredNumbers = findElementsAboveLimit(new[] { 1, 2, -5, 8, -3, 9, -7 }, 4);

//for (int i = 0; i < filteredNumbers.Length; i++)
//{
//    Console.WriteLine(filteredNumbers[i]);
//}

//void matchAndMultiply(int[] numbers, bool[] shouldMultiplyValues)
//{
//    int length = Math.Min(shouldMultiplyValues.Length, numbers.Length);
//    int result = 1;

//    for (int i = 0; i < length; i++)
//    {
//        if (shouldMultiplyValues[i])
//        {
//            result *= numbers[i];
//        }
//    }
//    Console.WriteLine($"Result {result}");
//}

//matchAndMultiply(new[] { 1, 2, 3, 4, 5 }, new[] { true, false, true, true, true, false });

//string[] RemoveSameElements(string[] elements)
//{
//    string[] filteredElements = new string[elements.Length];
//    int count = 0;

//    foreach(string element in elements)
//    {
//        bool hasElement = false;
//        foreach(string filteredElement in filteredElements)
//        {
//            if(filteredElement == element.ToLower())
//            {
//                hasElement = true;
//                break;
//            }
//        }
//        if (!hasElement)
//        {
//            filteredElements[count] = element.ToLower();
//            count += 1;
//        }
//    }
//    Array.Resize(ref filteredElements, count);
//    return filteredElements; 
//}

//string[] filteredElements = RemoveSameElements(new[] { "Google", "google", "test", "TEST", "youtube", "FACEBOOK" });
//foreach(string e in filteredElements)
//{
//    Console.WriteLine("element: " + e);
//}


//int a = 1; // 2 3 4 5 4
//int b = ++a + ++a; //  2 + 3 = 5 6 7 6 5 6
//int c = b++ + ++a; //  5 + 4 = 9 8 9

//Console.WriteLine($"{a} {b} {c}");

// 
//Console.WriteLine($"{a++ + ++b} {c-- - --b} {++c - b--} {a-- - ++b} {a} {b} {c}");
//11 3 3 - 1
// Aynur 11 3 4 -1 4 6 9 -
// Yusif 11 3 3 -1 4 6 9
// Elmin 11 4 4 -3 4 6 9 -
// Nigar, Kamil 11 3 3 -1 4 6 9
// Isa 11 2 3 -1 4 6 9 -
// Leyla 11 3 3 -4 4 6 9 -
// Benovshe 11 3 3 -1 4 6 9


//try
//{
//    int[] myArray = new int[] { 1, 2, 3 };
//    Console.WriteLine(myArray[9]);
//}
//catch(Exception e)
//{
//    Console.WriteLine(e);
//}


//Console.WriteLine("Kod davam edir");

void SetAge (int age)
{
    if (age < 0)
    {
        throw new Exception("Age 0 dan boyuk olmalidir!");
    }

    Console.WriteLine("Ugurlu emeliyyat");
}


try
{
    int age = Convert.ToInt32(Console.ReadLine());
    SetAge(age);
}
catch (FormatException exc)
{
    Console.WriteLine("Number girin");
}
catch(Exception exc)
{
    Console.WriteLine(exc.Message);
}
finally{
    Console.WriteLine("Bitti program");
}




