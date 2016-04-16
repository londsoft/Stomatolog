using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stomatolog.Domain;
using Stomatolog.Domain.Models;

namespace Stomatolog.Cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var db = new DentistContext())
                {
                    db.Database.CreateIfNotExists();
                    Patient patient = new Patient()
                    {
                        Name = "Tomek",
                        Surname = "Walasek",
                        Diagram = new Diagram { PozX = 0, PozY = 1, Color = 1 },
                        Visits = new List<Visit>
                        {
                            new Visit { DateOfVisit = DateTime.Now, Description = "asfasf"},
                            new Visit { DateOfVisit = DateTime.Now.AddDays(1), Description = "asdasdas"}
                        }
                    };

                    db.Patients.Add(patient);
                    db.SaveChanges();
                }
                Console.WriteLine("Done...");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fail... {0}\r\n{1}", ex.Message, ex.InnerException);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    } // class
} // namespace
