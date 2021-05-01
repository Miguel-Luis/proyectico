using System;
using CoreSchool;

namespace Proyectico
{
    class Program
    {
        static void Main(string[] args)
        {
            School school = new School("Genialidad", "Cra 5A #26-66", TypeSchool.Primary);

            Console.WriteLine(school);

            //school.Stamp();
        }
    }
}
