//Animal animal = new Animal("dafi"); // Qeti olmaz
Duck duck1 = new Duck("donald");

duck1.Swim();
//duck1.MakeNoise();
//duck1.Test();

Dog dog1 = new Dog("spark");

//dog1.MakeNoise();

Animal[] animals = new Animal[2];
animals[0] = dog1;
animals[1] = duck1;


foreach(Animal animal in animals)
{
    animal.MakeNoise();
}

for(int i = 0; i < animals.Length; i++)
{
    animals[i].MakeNoise();
}