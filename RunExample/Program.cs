﻿using System;
using System.Collections.Generic;
using ClassLibrary1;
using Solid_Examples;


namespace RunExample
{
    class Program
    {
        static void Main(string[] args)
        {
           // RunEventsAndDelegates();
            new Copy().CopyIt();
            Console.ReadLine();
            //old examples below
            var schoolAddress = new Address("Bucuresti", "Mihai Eminescu", "19-21");
            var andrei = new Student("AndreiRoca", new DateTime(1991, 1, 5), schoolAddress);
            andrei.Sex = Sex.male;
            var ziuaDanei = new DateTime(1964, 5, 14);
            Student dana = new Student("Daniela", ziuaDanei, new Address("Rosu", "Sperantei", "parter"));
            dana.Sex = Sex.female;
            DateTime luanasBday = new DateTime(1980, 12, 29);
            Person luana = new Student("Luana", luanasBday, schoolAddress);
            luana.Sex = Sex.female;
            var george = new Teacher("George", DateTime.Now, schoolAddress, 0);
            Curs Incepatori1 = new Curs("Incepatori", 2017, george);
            andrei.AddClass(Incepatori1);
            dana.AddClass(Incepatori1);
            Curs Incepatori2 = new Curs("Incepatori", 2017, george);
            var studentLuana = (Student)luana;
            studentLuana.AddClass(Incepatori2);
            Curs Incepatori = new Curs("Incepatori", 2018, george);
            var orar = new Orar();
            //orar.AddSession3(ClassLibrary1.DayOfWeek.Luni, 19, 120);
            //orar.AddSession3(ClassLibrary1.DayOfWeek.Miercuri, 19, 120);
            //orar.AddSession3(ClassLibrary1.DayOfWeek.Luni, 14, 80);
            Incepatori.Orar = orar;
            Address unknown = new Address("Unknown", "Unknown", "");
            var student0 = new Student("Adi", DateTime.Now, unknown);
            Student student1 = new Student("Tibi", DateTime.Now, unknown);
            var student2 = new Student("Titu", DateTime.Now, unknown);
            Incepatori.AddStudent(student0);
            Incepatori.AddStudent(student1);
            Incepatori.AddStudent(student2);
            Student[] studentiIncepatori = new Student[] { student0, student1, student2 };
            Incepatori.Students = new List<Student>();
            for (int i = 0; i < studentiIncepatori.Length; i++)
            {
                Incepatori.AddStudent(studentiIncepatori[i]);
            }
            Incepatori.Students = new List<Student>();
            foreach (var item in studentiIncepatori)
            {
                Incepatori.AddStudent(item);
            }
            Incepatori.Category = Category.Informatica;
            Console.WriteLine(Incepatori); //Incepatori.Afisare();
            //Console.ReadLine();
            Person IonIonelVasile = new Teacher("IonIonelVasile", DateTime.Now, schoolAddress, 1000);
            int a3 = ((Teacher)IonIonelVasile).Wage + 1;
            Person AndyDeLa = new Student("AndyDeLa", DateTime.Now, schoolAddress);
            AndyDeLa = Promote(AndyDeLa);
            int a4 = ((Teacher)AndyDeLa).Wage + 1;
            Console.ReadLine();

        }

        private static Person Promote(Person pupil)
        {
            return new Teacher(pupil.Name, pupil.DOB, pupil.Address, 0);
        }
        //private static void RunEventsAndDelegates()
        //{
        //    (new EventSubscriber()).XeventSubscriber();
        //    ExampleEvent.Main(new string[0]);
        //}
    }
}
