using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Students_Info
{
    class Program
    {
        //Функция отвечает за вывод информации о студентах
        private static void get_students_info(string _path)
        {
            string[] text;
            using (StreamReader reader = new StreamReader(_path))
            {
                text = reader.ReadToEnd().Split('\n');
            }
            Dictionary<string, DateTime> students = new Dictionary<string, DateTime>();
            foreach(string stroka in text)
            {
                students.Add(stroka.Split(" - ")[0], Convert.ToDateTime(stroka.Split(" - ")[1]));
            }

            //Сортировка студентов по датам рождения
            var sorted_students = from student in students
                                  orderby student.Value
                                  select student;
            //Ещё один из вариантов:
            //var sorted_students = students.OrderBy(x => x.Value);

            //Вывод информации о студентах
            Console.WriteLine("\nТаблица ФИО и даты рождения всех студентов, отсортированных по дате рождения:");
            foreach (var student in sorted_students)
            {
                Console.WriteLine("{0} - {1}", student.Key, student.Value.ToShortDateString());
            }
        }
        static void Main(string[] args)
        {
            //Вывод информации о студентах в остортированном по датам рождения порядке
            Console.Write("Введите путь к файлу, в котором указан список студентов и их дни рождения -> ");
            string path = Console.ReadLine();
            get_students_info(path);
            Console.ReadKey();
        }
    }
}
