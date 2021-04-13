using System;
using System.Data.Entity;

namespace Kartkowka
{
    public class Patient
    {
        public int Id { get; set; }

        public string Surname { get; set; }
    }

    public class Poczekalnia : DbContext
    {
        public DbSet<Patient> Patients{ get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            using (var db = new Poczekalnia())
            {
                var s = new Patient() { Surname = "Kowalski" };

                db.Patients.Add(s);
                db.SaveChanges();

                foreach(var ss in db.Patients)
                {
                    Console.WriteLine($"Nazwiska pacjenta: {ss.Surname}");
                }
            }
        }
    }
}
