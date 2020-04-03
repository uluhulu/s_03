using System;
using System.Collections.Generic;
using System.Linq;

namespace s_03
{
	class Program
	{
        static void Main(string[] args)
        {
            List<Log> logs = new List<Log>
            {
               new Log {requests=50 , date =DateTime.UtcNow.ToShortDateString(), dayOfWeek = DayOfWeek.Monday.ToString()},
               new Log {requests=100 , date =DateTime.UtcNow.ToShortDateString(), dayOfWeek = DayOfWeek.Tuesday.ToString()},
               new Log {requests=110 , date =DateTime.UtcNow.ToShortDateString(), dayOfWeek = DayOfWeek.Thursday.ToString()},
               new Log {requests=70 , date =DateTime.UtcNow.ToShortDateString(), dayOfWeek = DayOfWeek.Wednesday.ToString()},
               new Log {requests=60 , date =DateTime.UtcNow.ToShortDateString(), dayOfWeek = DayOfWeek.Friday.ToString()},
               new Log {requests=40 , date =DateTime.UtcNow.ToShortDateString(), dayOfWeek = DayOfWeek.Saturday.ToString()},
               new Log {requests=100 , date =DateTime.UtcNow.ToShortDateString(), dayOfWeek = DayOfWeek.Sunday.ToString()},
               new Log {requests=5 , date =DateTime.UtcNow.ToShortDateString(), dayOfWeek = DayOfWeek.Monday.ToString()},
               new Log {requests=30 , date =DateTime.UtcNow.ToShortDateString(), dayOfWeek = DayOfWeek.Tuesday.ToString()},
               new Log {requests=40 , date =DateTime.UtcNow.ToShortDateString(), dayOfWeek = DayOfWeek.Thursday.ToString()},
               new Log {requests=50 , date =DateTime.UtcNow.ToShortDateString(), dayOfWeek = DayOfWeek.Wednesday.ToString()},
               new Log {requests=100 , date =DateTime.UtcNow.ToShortDateString(), dayOfWeek = DayOfWeek.Friday.ToString()},


            };

            var logGroups = logs
                .GroupBy(l => l.dayOfWeek)
                .Select(g => new {
                    g.Key,
                    AverageRequest = g.Average(p => p.requests) });

            foreach (var l in logGroups)
            {
                Console.WriteLine("DayOfWeek = {0}, Total price = {1}",
        l.Key, l.AverageRequest);
            }
        }


	}

	public class Log
	{
		public int requests { get; set; }
		public string date { get; set; }
		public string dayOfWeek { get; set; }

	}
}

