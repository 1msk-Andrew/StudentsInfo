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
            Dictionary<string, string> students = new Dictionary<string, string>();
            foreach(string stroka in text)
            {
                students.Add(stroka.Split(" - ")[0], stroka.Split(" - ")[1]);
            }
            //TODO: Сортировка студентов по датам рождения
            //TODO: вывод информации о студентах
        }
        static void Main(string[] args)
        {

        }
    }
}
