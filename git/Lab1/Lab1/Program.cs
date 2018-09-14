using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    //commit one
    //commit two
    //commit three
    //commit one for dev
    //commit two for dev
    class Program
    {
        static List<string> Students = new List<string>() { "Малинчик Марина", "Якубейко Юлия",
                                                            "Загнетова Анастасия", "Поляков Ярослав",
                                                            "Пуцыкович Алексей", "Фурсиков Алексей"};
        static int[][] Marks = new int[][]{ new int[] { 7, 7, 9, 10, 8 }, new int[]{ 6, 7, 9, 6, 8 },
                                            new int[]{ 6, 7, 7, 8, 8 },new int[]{ 6, 5, 6, 10, 9 },
                                            new int[]{ 5, 6, 7, 6, 7 }, new int[]{ 6,7, 6, 7, 8 }};

        static void ShowStudents() 
        {
            for (int i = 0; i < Students.Count; i++)
            {
                Console.WriteLine(i + " " + Students[i]);
            }
            Console.WriteLine();
        }
        
        static void ShowMarks()
        {
            int ID;
            ShowStudents();
            Console.WriteLine("Введите номер студента");
            ID = Convert.ToInt32(Console.ReadLine());
            if (ID < 0 && ID > Students.Count)
            {
                Console.WriteLine("Неверный номер!");
            }
            else
            {
                Console.Write(Students[ID] + ": ");
                foreach (var mark in Marks[ID])
                {
                    Console.Write(mark + " ");
                }
                Console.WriteLine();
            }
        }
        
        static void CountAverageScore()
        {
            double AS = 0;
            int ID;
            ShowStudents();
            Console.WriteLine("Введите номер студента");
            ID = Convert.ToInt32(Console.ReadLine());
            if (ID < 0 && ID > Students.Count)
            {
                Console.WriteLine("Неверный номер!");
            }
            else
            {
                foreach (var mark in Marks[ID])
                {
                    AS += mark;
                }
                AS = AS / Marks[ID].Length;
                Console.WriteLine("Ср.балл = " + AS);
            }
        }

        static void CountTotalAverageScore()
        {
            double AS = 0;
            foreach (var mark in Marks)
            {
                int avg = 0;
                foreach (var num in mark)
                {
                    avg += num;
                }
                avg = avg / mark.Length;
                AS += avg;
            }
            AS = AS / Marks.Length;
            Console.WriteLine("Ср.балл группы = " + Math.Round(AS, 1));

        }
            static void Main(string[] args)
        {
            int k;
            do
            {
                Console.WriteLine("1 - Список студентов\n2 - Посмотреть оценки\n" +
                                  "3 - Посчитать ср.балл студента\n4 - Посчитать ср.балл группы\n0 - выйти");

                k = Convert.ToInt32(Console.ReadLine());

                switch (k)
                {
                    case 1: ShowStudents(); break;
                    case 2: ShowMarks(); break;
                    case 3: CountAverageScore(); break;
                    case 4: CountTotalAverageScore(); break;
                    case 0: Environment.Exit(0); break;
                }
            }
            while (k != 0);
        }
    }
}
