bool isFinished = false;
Console.WriteLine("Xoş gəldiniz!!");

while (!isFinished)
{
    Console.WriteLine();
    Console.WriteLine("Aşağıdakılardan birini seçin:");
    Console.WriteLine("1. Yeni customer əlavə etmək");
    Console.WriteLine("2. Var olan customeri seçmək");
    Console.WriteLine("3. Çıxış");
    int choice;
    int.TryParse(Console.ReadLine(), out choice);
    switch (choice)
    {
        case 1:
        startNewCustomerLabel:
            Console.Write("Yeni customerin fin kodunu girin: ");
            string fin = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(fin) || fin.Trim().Contains(" "))
            {
                Console.WriteLine("Fin kodu dogru girin!");
                goto startNewCustomerLabel;
            }
            for (int i = 0; i < Customer.customers.Length; i++)
            {
                if (Customer.customers[i].ID.Trim().ToLower() == fin.Trim().ToLower())
                {
                    Console.WriteLine("Bu fin kod artıq istifadə olunur.Yenidən girin!");
                    goto startNewCustomerLabel;
                }
            }
        newCustomerNameLabel:
            Console.Write("Yeni customerin adını girin: ");
            string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Adı dogru girin!");
                goto newCustomerNameLabel;
            }
        newCustomerSurnameLabel:
            Console.Write("Yeni customerin soyadını girin: ");
            string surname = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(surname))
            {
                Console.WriteLine("Soyadı dogru girin!");
                goto newCustomerSurnameLabel;
            }
        newCustomerAgeLabel:
            Console.Write("Yeni customerin yaşını girin: ");
            int age;
            int.TryParse(Console.ReadLine(), out age);
            if (age < 18)
            {
                Console.WriteLine("Yaşı dogru girin! (Yaş 18 dən böyük olmalıdır!)");
                goto newCustomerAgeLabel;
            }
            Customer customer = new Customer(fin, name, surname, age);
            Console.WriteLine("Yeni Customer yaradıldı.");
            customer.PrintPersonInfo();
            break;
        case 2:
            Customer[] customers = Customer.customers;
            if (customers.Length == 0)
            {
                Console.WriteLine("Hazirda her hansi bir customer yoxdur!");
                break;
            }
            Console.WriteLine("Customer siyahısı:");
            for (int i = 0; i < customers.Length; i++)
            {
                Console.Write($"{i + 1}. ");
                customers[i].PrintPersonInfo();
            }
            Console.WriteLine("\nƏməliyyat aparmaq istədiyiniz customeri seçin.");
        chosenCustomerLabel:
            Console.Write("Customer no girin: ");
            int chosenCustomerNo;
            int.TryParse(Console.ReadLine(), out chosenCustomerNo);
            if (chosenCustomerNo == 0 || chosenCustomerNo > customers.Length)
            {
                Console.WriteLine("Düzgün girin!");
                goto chosenCustomerLabel;
            }
            Console.WriteLine("\nSecilen customer bilgileri: ");
            Customer chosenCustomer = customers[chosenCustomerNo - 1];
            chosenCustomer.PrintPersonInfo();

        chosenOperationNoLabel:
            Console.WriteLine("Secilen customer üzərində aparıla biləcək əməliyyatlar:");
            Console.WriteLine("1. Pulqabinda olan meblegi gostermek.");
            Console.WriteLine("2. Pulqabina medaxil etmek.");
            Console.WriteLine("3. Pulqabindan mexaric etmek.");
            Console.WriteLine("4. Geri");
            int chosenOperationNo;
            int.TryParse(Console.ReadLine(), out chosenOperationNo);

            switch (chosenOperationNo)
            {
                case 1:
                    Console.WriteLine($"Pul qabindaki mebleg: {chosenCustomer.Money}\n");
                    goto chosenOperationNoLabel;
                case 2:
                cashInLabel:
                    Console.Write("Daxil edin: ");
                    int cashIn;
                    int.TryParse(Console.ReadLine(), out cashIn);
                    if (cashIn <= 0)
                    {
                        Console.WriteLine("Düzgün girin!");
                        goto cashInLabel;
                    }
                    chosenCustomer.Money += cashIn;
                    Console.WriteLine("Hesaba medaxil edildi!\n");
                    goto chosenOperationNoLabel;
                case 3:
                cashOutLabel:
                    Console.Write("Daxil edin: ");
                    int cashOut;
                    int.TryParse(Console.ReadLine(), out cashOut);
                    if (cashOut <= 0)
                    {
                        Console.WriteLine("Düzgün girin!");
                        goto cashOutLabel;
                    }
                    if (cashOut > chosenCustomer.Money)
                    {
                        Console.WriteLine("Pulqabinda kifayet qeder mebleg yoxdur!\n");
                        goto chosenOperationNoLabel;
                    }
                    chosenCustomer.Money -= cashOut;
                    Console.WriteLine("Hesabdan mexaric edildi!\n");
                    goto chosenOperationNoLabel;
                case 4:
                    break;
                default:
                    Console.WriteLine("Düzgün girin!");
                    goto chosenOperationNoLabel;
            }
            break;
        case 3:
            Console.WriteLine("Yaxsi yol!");
            isFinished = true;
            break;
        default:
            Console.WriteLine("Duzgun girmediniz! Yeniden yoxlayin.");
            break;
    }
}

