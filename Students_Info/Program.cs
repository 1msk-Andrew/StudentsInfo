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

            //TODO: Вывод информации о студентах

        }
        static void Main(string[] args)
        {

        }
    }
}
