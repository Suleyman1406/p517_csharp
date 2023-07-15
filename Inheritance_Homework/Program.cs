Person person = new Person("Suleyman", "Dadashov", 24);
person.PrintPersonInfo();

Teacher teacher1 = new Teacher("Mehemmed", "Ceferli", 15);
teacher1.PrintPersonInfo();

Teacher teacher2 = new Teacher("Imameli", "BasiQarli", 17);
teacher2.PrintPersonInfo();

Console.WriteLine($"student count: {Student.studentCount} ");

Student student1 = new Student("Laçın", "Gunduzov", 15, teacher1);
student1.PrintPersonInfo();
student1.PrintTeacherName();

Student student2 = new Student("Rais", "Crane", 45, teacher2);
student2.PrintPersonInfo();
student2.PrintTeacherName();

Console.WriteLine($"student count: {Student.studentCount} ");
