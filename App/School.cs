using System;

namespace CoreSchool
{
    class School 
    {
        string name;
        string address;
        TypeSchool type_school;

        // Constructor de la clase
        public School(string name, string address, TypeSchool type_school) {
            this.name = name;
            this.address = address;
            this.type_school = type_school;
        }

        public string Name { get; set; }
        public string Address {get; set; }
        public TypeSchool Type_School {get; set; }

        // Función timbrar
        public void Stamp()
        {
            // La leyenda de Zelda
            Console.Beep(987, 1000); //Si
            Console.Beep(1174, 500); //Re'
            Console.Beep(880, 1500); //La

            Console.Beep(783, 250); //Sol
            Console.Beep(880, 250); //La
            Console.Beep(987, 1000); //Si

            Console.Beep(1174, 500); //Re'
            Console.Beep(880, 1500); //La

            Console.Beep(987, 1000); //Si
            Console.Beep(1174, 500); //Re'
            Console.Beep(1760, 1000); //La'
            Console.Beep(1567, 500); //Sol'
            Console.Beep(1174, 1000); //Re'

            Console.Beep(1046, 250); //Do
            Console.Beep(987, 250); //Si
            Console.Beep(880, 1000); //La
        }

        // Método para imprimir la información del objeto
        public override string ToString()
        {
            return $"Nombre: {name} \nTipo {type_school} \nDirección {address}";
        }
    }
}