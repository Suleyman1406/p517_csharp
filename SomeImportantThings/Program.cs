//dynamic b = "asd";
//b = 12;

//const int a = 12;
//int a = 777;


//checked
//{
//    byte b = (byte)a;
//    Console.WriteLine(b);
//}


//void Test(int a, int b, int c)
//{

//}

//Test(b: 12, a: 11, c: 66);



//var student = new { name = "Suleyman", surname = "Dadashov" };

//Console.WriteLine(student.name);
//Console.WriteLine(student.surname);
//Console.WriteLine(student.GetType());

//using test;
//namespace test1
//{
//    class Program
//    {
//        static void Main()
//        {
//            Animal animal = new Animal("dog");
//        }
//    }
//}

//Console.WriteLine((int)Day.Monday);
//Console.WriteLine((int)Day.Thursday);

//enum Day
//{
//    Monday = 10, Sunday = 20, Thursday
//}

//int score = 90;

//if(score>100 || score < 0)
//{
//    Console.WriteLine("Invalid Score");
//}else if (score< (int)Score.F)
//{
//    Console.WriteLine("F");
//}
//else if (score < (int)Score.D)
//{
//    Console.WriteLine("D");
//}
//else if (score < (int)Score.C)
//{
//    Console.WriteLine("C");
//}
//else if (score < (int)Score.B)
//{
//    Console.WriteLine("B");
//}
//else
//{
//    Console.WriteLine("A");
//}

////int AScore = 100,Bscore = 95;

//enum Score
//{
//    F= 60, D = 70, C = 80, B=95, A=100
//}


//int a = 15;
//int b = 15;

//if (a > b)
//{
//    Console.WriteLine("A boyukdur b");
//}
//else
//{
//    Console.WriteLine("A kicikdir b");
//}

//Console.WriteLine(a > b ? "A boyukdur b" : a < b ? "A kicikdir b" : "a beraberdir b");

//int a =12;

//void test(out int num)
//{
//    num = num + 1;
//    //num = 16;
//}

//test(out a);
//Console.WriteLine(a);

//int[] a = new int[3];


//Array.Resize(ref a, 3);

//string a = "2s3";
//int b;

//TryParse(a,out b);
//Console.WriteLine(b);

//void TryParse(string value,out int result)
//{
//    try
//    {
//        result = Convert.ToInt32(value);
//    }
//    catch (Exception e)
//    {
//        result = 0;
//    }
//}