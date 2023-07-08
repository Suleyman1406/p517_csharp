
Student student1 = new Student("Aqil", "Soltanli");

student1.setScores(88, 44.8, 88);

Console.WriteLine("Aqil's avarage: " + student1.getAvarage());

Course course1 = new Course("Code Academy", "Programming&Design course");
Student student2 = new Student("Sahrom", "Recebov", course1);

student2.setScores(12, 99, 99);

Console.WriteLine("Sahrom's avarage: " + student2.getAvarage());

Course student2Course = student2.getCourse();
student2Course.printCourseInfo();

student1.setCourse(new Course("DadAcademy", "Programming&Design course"));
student1.getCourse().printCourseInfo();
