Cat tom = new Cat("tom",12);
tom.Run();
tom.MakeNoise();

Dog mike = new Dog("mike", 4);
mike.Run();
mike.MakeNoise();

Rabbit bembi = new Rabbit("Bembi", 6, 2);

//Console.WriteLine(bembi.name); // xeta vermelidi
Console.WriteLine(bembi.longEarCount);
bembi.Run();
bembi.MakeNoise();

Animal animal = new Animal("Animal", 10);
animal.Run();
animal.MakeNoise();
