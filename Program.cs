using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ExceptionHandling
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<LogEntry> RoomList = new List<LogEntry>();
            LogEntry student = new LogEntry();

            string roomInput = "";
            try
            {
                Console.WriteLine("Enter a room:");
                roomInput = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            student.room = roomInput;

            Console.WriteLine("Enter a student:");
            string nameInput = Console.ReadLine();
            student.name = nameInput;

            int durationInput = 0;


            try
            {
                Console.WriteLine("Time spent in classroom:");
                durationInput = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            student.duration = durationInput;

            var dateOnlyString = "";

            try
            {
                Console.WriteLine("Date of entry (ie 10/08/2020):");
                DateTime dateInput = DateTime.Parse(Console.ReadLine());
                dateOnlyString = dateInput.ToLongDateString();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            var timeOnlyString = "";

            try
            {
                Console.WriteLine("Time of entry (ie 15:30):");
                DateTime timeInput = DateTime.Parse(Console.ReadLine());
                timeOnlyString = timeInput.ToLongTimeString();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();
            Console.WriteLine("Student Log Entry");
            Console.WriteLine();
            Console.WriteLine("Date: " + dateOnlyString);
            Console.WriteLine("Time: " + timeOnlyString);
            Console.WriteLine();
            Console.WriteLine("Student name: " + student.name);
            Console.WriteLine();
            Console.WriteLine("Room number: " + student.room);
            Console.WriteLine("Session length: " + student.duration + " minutes");
            Console.WriteLine();

        }
    }
}

