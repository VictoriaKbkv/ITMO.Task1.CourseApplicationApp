using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.CourseApplicationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const byte NumberOfQuestions = 4;
            const double Pass = 0.5;
            string[] Questions = { "1. 1+3=?", "2. 5+5=?", "3. 9*3=?", "4. 16:4=?" };
            string[] CorrectAnswer = { "4", "10", "27", "4" };

            Console.WriteLine("Вы даете согласие на обработку персональных данных? Да/Нет");
            string Agreement = Console.ReadLine();

            if (Agreement == "Да")
            {
                Console.WriteLine("Ввведите фимилию, имя и отчество");
                string Name = Console.ReadLine();
                Console.WriteLine("Введите номер телефона");
                string Tel = Console.ReadLine();

                // Далее должна запускаться функция проверки, записан ли данный пользователь на курс
                // Функция возвращает значение true для переменной Check, если пользователь уже записан на курс

                bool Check = false;
                if (Check == true)
                {
                    Console.WriteLine("Вы уже записаны на этот курс.");
                }
                else
                {
                    byte CountAnswers = 0;
                    Console.WriteLine("Пройдите тестирование для записи на курс");

                    for (int CountQuestions = 0; CountQuestions <= NumberOfQuestions-1; CountQuestions++)
                    {
                        Console.WriteLine(Questions[CountQuestions]);
                        String Answer = Console.ReadLine();
                        if (Answer == CorrectAnswer[CountQuestions])
                        {
                            CountAnswers++;
                        }

                    }
                    if (CountAnswers > NumberOfQuestions * Pass)
                    {
                        Console.WriteLine("Вы успешно прошли тестирование и записаны на курс.");
                        // Далее должна запускаться процедура передачи значений переменных Name, Tel в список слушателей курса
                    }
                    else
                    {
                        Console.WriteLine("Вы не справились с тестом и не можете быть записаны на курс.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Без согласия на обработку персональных данных мы не можем записать Вас на курс.");
            }
        }
    }
}
