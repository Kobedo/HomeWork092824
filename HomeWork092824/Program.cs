namespace HomeWork092824
{

    internal class Program
    {
        static void Main()
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(@"Добро пожаловать в школу C#er!
Чтобы начать обучение, необходимо зарегистрироваться
Нажмите <любую клавишу> для начала регистрации или <ESC> для выхода из программы");

            var startRegistration = Console.ReadKey(intercept: true); //ожидаем ввод от пользователя
            
            if (startRegistration.Key != ConsoleKey.Escape)
            {
                int minAge = 18;
                int maxAge = 85;
                int wastedAge = 100;
                string discount = "20%";
                int discountAge = 65;
                int lastStudentID = 1000;
                int studentID = ++lastStudentID;

                Console.WriteLine("\nВведите ваше имя...");
                string studentName = Console.ReadLine();

                Console.WriteLine("\nВведите вашу фамилию...");
                string studentLastName = Console.ReadLine();

                Console.WriteLine("\nВведите ваше отчество...");
                string studentMiddleName = Console.ReadLine();

                Console.WriteLine(@"Очень приятно, " + studentName + "!\n" +
"Давайте же узнаем ваш возраст\n" +
"Обращаем ваше внимение, что к зачислению подходят студенты в возрасте от 18 до 85 лет!\n" +
"Студенты страше 65 лет получают скидку в размере " + discount);
                var age = Console.ReadLine();
                int studentAge;
                var isAgeParsable = int.TryParse(age, out studentAge);

                if (studentAge > minAge && studentAge < maxAge && studentAge < wastedAge)
                {
                    Console.WriteLine("Укажите ваш GPA");
                    var studentGPA = Console.ReadLine();

                    Random rnd = new Random();
                    int randomA = rnd.Next(0, 100);
                    int randomB = rnd.Next(101, 200);

                    Console.WriteLine(@"Для завершения регистрации нам нужно убедиться, что вы не робот" + 
"\nВведите сумму этих чисел: " + randomA + " + " + randomB);

                    var RandomAnswer = Console.ReadLine();
                    int studentRandomAnswer;
                    var isRandomAnswerParsable = int.TryParse(RandomAnswer, out studentRandomAnswer);
                    if (studentRandomAnswer == randomA + randomB)
                    {
                        if (studentAge >= discountAge)
                        {

                            Console.WriteLine("Поздравляем! Вы прошли регистрацию!" +
                                "\nДанные вашего профиля:" +
                                "\nНомер студента: " + studentID +
                                "\nИмя: " + studentName +
                                "\nФамилия: " + studentLastName +
                                "\nОтчество: " + studentMiddleName +
                                "\nВозраст: " + studentAge +
                                "\nGPA: " + studentGPA +
                                "\nСкидка на обучение: " + discount);
                        }
                        else
                        {
                            Console.WriteLine("Поздравляем! Вы прошли регистрацию!" +
                                "\nДанные вашего профиля:" +
                                "\nНомер студента: " + studentID +
                                "\nИмя: " + studentName +
                                "\nФамилия: " + studentLastName +
                                "\nОтчество: " + studentMiddleName +
                                "\nВозраст: " + studentAge +
                                "\nGPA: " + studentGPA +
                                "\nСкидка на обучение: 0%");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Одна ошибка и ты ошибся");
                    }
                    
                }
                else if (studentAge > maxAge && studentAge < wastedAge)
                {
                    Console.WriteLine("К сожалению, вы слишком стары");
                }
                else if (studentAge >= wastedAge)
                {
                    Console.WriteLine("Скорее всего вы уже потрачены");
                }
                else if (studentAge < minAge)
                {
                    Console.WriteLine("Агу, агугугу... Школу сначала закончи, сопля");
                }
            }
            else
            {
                Console.WriteLine("\nГрусть, пачаль, досада...");
            }
        }
    }
}