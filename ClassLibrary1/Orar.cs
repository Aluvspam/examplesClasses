using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class Orar
    {
        public int SessionsPerWeek;
        public List<Session> Schedule;

        public Orar()
        {
            Schedule = new List<Session>();
            SessionsPerWeek = 0;
        }

        public void AddSession(Session s)
        {
            Schedule.Add(s);
            SessionsPerWeek++;
        }
        public void AddSession0(DayOfWeek d, double startingTime, int duration)
        {
            var session = new Session(d, startingTime, duration);
            Schedule.Add(session);
            SessionsPerWeek++;
        }
        public void AddSession1(DayOfWeek d, double startingTime, int duration)
        {
            var session = new Session(d, startingTime, duration);
            AddSession(session);
        }
        public void AddSession2(DayOfWeek d, double startingTime, int duration)
        {
            Schedule.Add(new Session(d, startingTime, duration));
            SessionsPerWeek++;
        }
        public void AddSession3(DayOfWeek d, double startingTime, int duration)
        {
            AddSession(new Session(d, startingTime, duration));
        }
        public void AddSession4(DayOfWeek d, double startingTime, int duration)
        {
            Session session = new Session(d, startingTime, duration);
            AddSession(session);
        }
        public override string ToString()
        {
            var result = "";
            for (int i = 0; i < Schedule.Count - 1; i++)
            {
                result += (i > 0 ? Constants.tab + Constants.tab : "") + Schedule[i] + Environment.NewLine;
            }
            if (Schedule.Count > 0)
            {
                result += (Schedule.Count > 1 ? Constants.tab + Constants.tab : "") + Schedule[Schedule.Count - 1];
            }
            else
            {
                result = "----";
            }
            return result;
        }
    }
}
