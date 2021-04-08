using System;

namespace listado
{
    class Estudiante
    {
        public string nombre, carnet;
        public int edad;
        public Boolean solvente;

       public Estudiante(string nombre, string carnet, int edad, Boolean solvente ){
           this.nombre=nombre;
           this.carnet=carnet;
           this.edad=edad;
           this.solvente=solvente;

       }
    }
}
