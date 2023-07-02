// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



//float test = 13.28888888888888888888888888888888888888888888F;
//double t = 13.5;
//decimal at = 15;

//char firstCharacter = 'A';
//string helloMessage = " Hello Code Academy";


//bool isPrime = false;
//int a = 14;
//int b = 16;
//if(a<b && (a>14 || b < 18))
//{
//    Console.WriteLine("True");
//}
//else
//{
//    Console.WriteLine("False");
//}

//if( a != 15 && a!= b)
//{
//    Console.WriteLine("Test");
//}

//var a = "test";

//string[] students = new string[4];
//students[0] = "Mehemmed";
//students[1] = "Isa";
//students[2] = "Kamil";

//string a = students[4];
//Console.WriteLine("test");

//string[] students1 = new string[3]{ "Mehemmed", "Isa", "Kamil" };
//string[] students2 = new string[] { "Mehemmed", "Isa", "Kamil" };
//string[] students3 = new []{ "Mehemmed", "Isa", "Kamil" };
//string[] students4 = { "Mehemmed", "Isa", "Kamil" };

//string[] students = { "Mehemmed", "Isa", "Kamil" };

//Console.WriteLine(students[2]);


//int[] numbers = new int[10];
//numbers[0] = 0;
//numbers[1] = 1;
//numbers[2] = 2;

//int[] numbers = {10,11,12,13,14,15,16,17,18,19};

// length 10
// i 0 1 2 3 4 5 6 7 8 9 10

//Console.WriteLine("Array length is {0}, {1}{1}{1}{0}" , numbers.Length, 16);

//for(int i = 0; i< numbers.Length; i++) // 
//{
//Console.Write(numbers[i]+" ");
//Console.WriteLine("1");
//}




//double[] weights = { 33.5, 66, 99.4 };
//char[] chars = new char[4];
//chars[0] = 'a';
//bool[] test = { true, false, true, true };

//Console.Write("Arrayin uzunlugu:  ");
//int length = Convert.ToInt32(Console.ReadLine());
//int[] numbers = new int[length];

//for(int i = 0; i<length; i++)
//{
//    Console.Write("Arrayin {0}. elementi: ", i);
//    numbers[i] = Convert.ToInt32(Console.ReadLine());
//}


//Console.Write("Axtarilan ededi girin: ");
//int userNumber = Convert.ToInt32(Console.ReadLine());

//int foundIdx = -1;

//for(int i = 0; i< numbers.Length; i++)
//{
//    if (numbers[i] == userNumber)
//    {
//        foundIdx = i;
//        break;
//    }
//}

//if (foundIdx == -1)
//{
//    Console.WriteLine("Tapilmadi");
//}
//else
//{
//    Console.WriteLine("Tapilan index {0}", foundIdx);
//}


//int[] numbers = { 1, 2, 3, 4, 9, 78, -4, 5, 6 };

//int max = numbers[0];
//int min = numbers[0];

//for (int i = 1; i<numbers.Length; i++)
//{
//    if (numbers[i] > max)
//    {
//        max = numbers[i];
//    }
//    else if (numbers[i]< min)
//    {
//        min = numbers[i];
//    }
//}

//Console.WriteLine("Max: {0}, Min: {1}", max, min);

//printHello();
//printHello();
//printHello();
//printHello();
//printHello();
//printHello();
//printHello();
//printHello();
//printSomething();
//printSomething();
//printSomething();
//printSomething();

//void printSomething()
//{
//    int a = 6;
//    int b = 8;
//    Console.WriteLine(a+b);
//}

//void printHello()
//{
//    Console.WriteLine("Hello");
//    Console.WriteLine("How are you?");

//}


//int a = 5;
//Console.WriteLine(a);


//void printHello(string name, string surname)
//{
//    Console.WriteLine("Hello {0} {1}", name, surname);
//}



//printHello("Suleyman", "Dadashow");
//printHello("Aynur", "Tahirova");


//void sum(int a, int b)
//{
//    Console.WriteLine(a + b);
//}

//Console.Write("1: ");
//int number1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("2: ");
//int number2 = Convert.ToInt32(Console.ReadLine());

//sum(number1, number2);



//int sum(int a, int b)
//{
//    return a + b;
//}

//int result = sum(2, 4);

//Console.WriteLine(result);




//void findMinMax(int[] nums)
//{
//    int max = nums[0];
//    int min = nums[0];

//    for (int i = 1; i < nums.Length; i++)
//    {
//        if (nums[i] > max)
//        {
//            max = nums[i];
//        }
//        else if (nums[i] < min)
//        {
//            min = nums[i];
//        }
//    }

//    Console.WriteLine("Max: {0}, Min: {1}", max, min);
//}

//int[] numbers1 = new int[3] { 1, 5, -88 };
//int[] numbers2 = new int[] { 8, 17, -12, -99, 2};

//findMinMax(numbers1);
//findMinMax(numbers2);


//int Sum(int a, int b)
//{
//    return a + b;
//}

//int result = Sum(1, 2);



//string MergeFullName(string name, string surname)
//{
//    return name + " " + surname;
//}

//string myFullName = MergeFullName("SUleyman", "Dadashow");
//Console.WriteLine(myFullName);
//string
//Console.WriteLine();




// int sum( params int[] numbers)
//{
//    int total = 0;

//    for(int i=0; i<numbers.Length; i++)
//    {
//        total += numbers[i];
//    }

//    return total;
//}

//int result = sum(1,2,3,4,5);

//Console.WriteLine(result);

// { 1,2,3,5, 3,7, 9,5 ,9} 5

//int CountValueInArray(int[] numbers, int value)
//{
//    int count = 0;

//    for(int i = 0; i<numbers.Length; i++)
//    {
//        if (numbers[i] == value)
//        {
//            count += 1;
//        }
//    }

//    return count;
//}


//Console.WriteLine(CountValueInArray(new[] { 1, 2, 3, 4, 5, 5, 5, 5 }, 5));
//Console.WriteLine(CountValueInArray(new[] { 1, 2, 3, 4, 5, 5, 5, 5 }, 99));


// {1, 2, 3}
// {1, 2, 4}


bool GetIsSame(int[] arr1, int[] arr2) {
    if(arr1.Length != arr2.Length) {
        return false;
    }

    for(int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i] != arr2[i])
        {
            return false;
        }
    }

    return true;
}

Console.WriteLine(GetIsSame(new[] {1,2,3}, new[] {1,2}));