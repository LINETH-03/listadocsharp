using System;

namespace listado
{
    class Estudiante
    {
        public string nombre, carnet;
        public int edad;
        public bool solvente;

       public Estudiante(string nombre, string carnet, int edad, bool solvente ){
           this.nombre=nombre;
           this.carnet=carnet;
           this.edad=edad;
           this.solvente=solvente;

       }
    }
}
