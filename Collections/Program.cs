//List<int> values = new List<int>() { 1,2,3};

//Console.WriteLine(values.Count);

//values.Add(12);
//values.Add(18);
//values.Add()

//values.AddRange(new int[] { 3, 4,88, 5, 6, 7, 7 });
//Console.WriteLine(values[6]);
//Console.WriteLine( values.ElementAt(3));

//values.Remove(88);
//values.RemoveRange(0,2);
//values.RemoveAll();
//values.RemoveAt(1);

//foreach (int value in values)
//{
//    Console.Write(value + " ");
//}

//using System.Collections;

//using System.Collections;

//using System.Collections;

//ArrayList myList = new ArrayList
//{
//    "asd",
//    12,
//    true,
//    's',
//    99.3
//};
//myList.Add("asd);
//myList.Add(12);
//myList.Add(true);
//myList.Add('s');
//myList.Add(99.3);
//Console.WriteLine(myList[2]);
//myList.ToArray()

//int a = 12;
//object b = a;
//object[] c = new object[] { "asd", 12, true, 'a' };


//Dictionary<string, string> dictionary = new Dictionary<string, string>
//{
//    { "test","test" },
//    { "value", "test" }
//};

//Console.WriteLine(dictionary["value"]);
//Console.WriteLine(dictionary["test"]);




//Dictionary<int, double> keyValuePairs = new Dictionary<int, double>();
//keyValuePairs.Add(1, 1.5);
//keyValuePairs.Add(2, 2.0);

//Console.WriteLine(keyValuePairs[1]);

//Dictionary<string, User> keyValuePairs = new Dictionary<string, User>();

//keyValuePairs.Add("asd123", new User("suleyman"));
//keyValuePairs.Add("123Salam", new User("isa"));

//Console.WriteLine(keyValuePairs["asd123"]);



//Dictionary<string, string> dictionary = new Dictionary<string, string>
//{
//    { "book","kitab" },
//    { "computer", "kompyuter" },
//    { "hand", "el" }
//};

//Console.WriteLine(dictionary.Count);

//dictionary.Remove("book");

//Console.WriteLine(dictionary.ContainsKey("book"));
//Console.WriteLine(dictionary.ContainsValue("esl"));

//foreach(var element in dictionary)
//{
//    Console.WriteLine(element.Key +": " + element.Value);
//}

//foreach(var element in dictionary.Values)
//{
//    Console.WriteLine(element);
//}
//foreach (var key in dictionary.Keys)
//{
//    Console.WriteLine(key);
//}



Queue<int> numbers = new Queue<int>();

//numbers.Enqueue(12);
//numbers.Enqueue(13);
//numbers.Enqueue(33);

//Console.WriteLine(numbers.Peek());
//numbers.Dequeue();
//Console.WriteLine(numbers.Peek());
//Console.WriteLine(numbers.Peek());
//Console.WriteLine(numbers.Dequeue());
//Console.WriteLine(numbers.Dequeue());
//Console.WriteLine(numbers.Dequeue());


//int value;
//numbers.TryDequeue(out value);
//Console.WriteLine(value);

//int value;
//numbers.TryPeek(out value);
//Console.WriteLine(value);



Stack<string> names = new();

names.Push("Isa");
names.Push("Aqil");
names.Push("Suleyman");

//Console.WriteLine(names.Peek());
//Console.WriteLine(names.Pop());
//Console.WriteLine(names.Pop());
//Console.WriteLine(names.Pop());
//string value;

//names.TryPop(out value);

//Console.WriteLine(value);

