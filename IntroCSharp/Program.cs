// C# intro array function

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


//bool GetIsSame(int[] arr1, int[] arr2) {
//    if(arr1.Length != arr2.Length) {
//        return false;
//    }

//    for(int i = 0; i < arr1.Length; i++)
//    {
//        if (arr1[i] != arr2[i])
//        {
//            return false;
//        }
//    }

//    return true;
//}

//Console.WriteLine(GetIsSame(new[] {1,2,3}, new[] {1,2}));





// ------------------------------------------------------------------------------------------------------------
// ------------------------------------------------------------------------------------------------------------
// ------------------------------------------------------------------------------------------------------------
// ------------------------------------------------------------------------------------------------------------
// ------------------------------------------------------------------------------------------------------------
// ------------------------------------------------------------------------------------------------------------
// ------------------------------------------------------------------------------------------------------------
// ------------------------------------------------------------------------------------------------------------

// Exercise

/*
 C. Js, Big-O, Flowchart
    1. Iki dəyişkən tanımlayın və dəyər mənimsədin. (from, to)
    2. Girilən aralıqda olan sadə ədədlərin ortalamasını hesablayın.
    Example:
    from = 12;
    to = 25;
    Ortalama 18       (13+17+19+23)/4
*/

//int from = 14;
//int to = 25;
//int sum = 0;
//int count = 0;

//for (int i = from; i <= to; i++) {
//    bool isPrime = true;

//    for (int j = 2; j < i; j++)
//    {
//        if(i%j==0)
//        {
//            isPrime = false;
//            break;
//        }
//    }

//    if(isPrime == true)
//    {
//        sum += i;
//        count += 1;
//    }
//}

//double avg = (double)sum / count;

//Console.WriteLine("Avarage: {0}", avg);


//int[] ReverseArray(int[] numbers)
//{
//    int[] reversedArray = new int[numbers.Length];

//    for(int i = 0; i<numbers.Length; i++)
//    {
//        reversedArray[reversedArray.Length - 1 - i] = numbers[i];
//    }

//    return reversedArray;
//}


//int[] numbers = new int[] { 1, 2, 3, 3, 4, 5, 6, 67, 7 };
//int[] newArr = ReverseArray(numbers);

//for (int i = 0; i < newArr.Length; i++)
//{
//    Console.WriteLine(newArr[i]);
//}

//string name = "Suleyman";
//string surname = "Dadashow";
//string fullName = String.Format("Fullname: {0} {1}", name, surname); 

//Console.WriteLine(fullName);


//string groupName = "P517";

//Console.WriteLine(groupName.Length);

//string text = "Bir boolean return boolean edən funskiya yaradin. Bu funksiya parametr olaraq integer dəyər alır.";

//Console.WriteLine(text.Trim().StartsWith("Bir"));
//Console.WriteLine(text.Trim());
//string text = "This is Trial.";
//Console.WriteLine(text.LastIndexOf("T"));
//string subText = text.Substring(4, 5);
//Console.WriteLine(text);
//Console.WriteLine(text.ToLower());
//Console.WriteLine(text.ToUpper());
//Console.WriteLine(text);
//Console.WriteLine(text.Replace(" ", ""));
//Console.WriteLine(text.Remove(3,8));

//int[] numbers = new int[5];
//numbers[0] = 2;
//numbers[1] = 6;
//numbers[2] = 6;
//numbers[3] = 8; 
//numbers[4] = 8;

//Array.Resize(ref numbers, 30);
//numbers[5] = 18;
//Console.WriteLine(numbers[3]);


//for(int i = 0; i<numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}

//foreach(int number in numbers)
//{
//    Console.WriteLine(number);
//}


//A.
//	1. Bir array return edən funksiya yaradın. Funksiya parametr olaraq array alır.
//	2. Funksiya girilən arraydəki elementlərin yerini bir sonrakı ilə(əgər varsa) dəyişib arrayi return eləməlidir.
//	Example:
//		func([1, 2, 3, 4, 5, 6, 7]) => [2, 1, 4, 3, 6, 5, 7]
//		func([4, 8, 12, 3 ]) => [8, 4, 3, 12]

//int[] ReverseNeighbour(int[] numbers)
//{
//    for(int i =0;i<numbers.Length-1; i+=2)
//    {
//        int temp = numbers[i]; 
//        numbers[i] = numbers[i + 1]; 
//        numbers[i + 1] = temp; 
//    }

//    return numbers;
//}

//int[] numbers = { 1, 2, 3, 4};

//int[] newNumbers = ReverseNeighbour(numbers);

//foreach(int t in numbers)
//{
//    Console.WriteLine(t);
//}

/*
 * 
 B.  // Array sort.
	1. Bir funksiya yaradın(hec birsey return elemeyecek). Funksiyar parametr olaraq integer array alacaq. (Nəzərə alaq ki arrayin minimal uzunluğu 5 olacaq.)
	2. Verilən arrayin içindəki ən böyük 4 ədədin toplamı ilə ən kiçik 4 ədədin toplamını ekrana yazdırın.
	Example: 
		func([1, 5, 2, 4, 8, 12, 3, -2]) => print 'Max: 29, Min: 4'
		func([9, 1, 3, 7, -6, -3, 2, 5]) => print 'Max: 24, Min: -6'
		func([4, 2, 6, 1, 3, 8, 9] => print 'Max 27, Min: 10'
*/

//void PrintMinMaxOfFour(int[] numbers)
//{
//    Array.Sort(numbers);
//    int min = numbers[0] + numbers[1] + numbers[2] + numbers[3];
//    int max = numbers[numbers.Length-1] + numbers[numbers.Length - 2] + numbers[numbers.Length - 3] + numbers[numbers.Length - 4];
//    Console.WriteLine("Min {0}, Max {1}", min, max);
//}

//PrintMinMaxOfFour(new[] { 1, 5, 2, 4, 8, 12, 3, -2 });

