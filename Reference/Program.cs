

//int a = 1;
//int b = a;
//a = 2;

//Console.WriteLine(b);

//Dog mike = new Dog("Mike");
//Dog reks = mike;
//mike.name = "reks";
//Console.WriteLine(reks.name);

//int[] a = { 1, 2, 3, 4 };
//int[] b = a;
//a[0] = 55;
//Console.WriteLine(b[0]);

//int test = 4;
//Any(test);
//Console.WriteLine(test);

//void Any(int a)
//{
//    a = 5;
//}

//int[] nums = { 1, 2, 3, 4 };

//Any(nums);
//Console.WriteLine(nums[0]);

//void Any(int[] numbers)
//{
//    numbers[0] = 88;
//}

Dog mike = new Dog("Mike");

Console.WriteLine(mike.name);
Any(mike);

void Any(Dog dog)
{
    dog.name = "rex";
}