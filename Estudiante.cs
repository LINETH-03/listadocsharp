using System;

namespace listado
{
    class Estudiante
    {
        public String nombre;
        public String carnet;
        public int edad;
        
        public Boolean solvente;

       public Estudiante(String nombre, String carnet, int edad, Boolean solvente ){
           this.nombre=nombre;
           this.carnet=carnet;
           this.edad=edad;
           this.solvente=solvente;

       }
    }
}
