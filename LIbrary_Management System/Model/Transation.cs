using System;
using System.Collections.Generic;
using System.Text;

namespace LIbrary_Management_System.Model
{
    class Transation
    {
        DateTime starting_date;
        DateTime Returing_date;
        DateTime Diffrence;

        public Transation(DateTime starting_date, DateTime returing_date)
        {
            this.Starting_date = starting_date;
            Returing_date1 = returing_date;
           // Diffrence = DateTime.Today - Returing_date;
        }

        public DateTime Starting_date { get => starting_date; set => starting_date = value; }
        public DateTime Returing_date1 { get => Returing_date; set => Returing_date = value; }
        public DateTime Diffrence1 { get => Diffrence; }
    }
}
