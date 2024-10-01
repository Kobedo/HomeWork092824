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
                Console.WriteLine("\nВведите ваше имя...");
                string studentName = Console.ReadLine();

                Console.WriteLine("\nВведите вашу фамилию...");
                string studentLastName = Console.ReadLine();

                Console.WriteLine("\nВведите ваше отчество...");
                string studentMiddleName = Console.ReadLine();

                Console.WriteLine(@"Очень приятно, " + studentName + "!\n" +
"Давайте же узнаем ваш возраст");

                Console.WriteLine("\nВведите месяц вашего рождения");
                //var birthMonth = Console.ReadLine();
                //var studentBirthMonth;
                //birthMonth = DateOnly.TryParse(birthMonth, out DateOnly studentBirthMonth));

            }
            else
            {
                Console.WriteLine("\nГрусть, пачаль, досада...");
            }
        }
    }
}