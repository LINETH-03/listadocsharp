using System;

namespace listado
{
    public class Program
    {
        static void Main(String [] args){
            Estudiante[] listadoestudiante = new Estudiante[2];
            notas[] listadonotas = new notas[2];
            int cont = 0;

            while (cont < 2)
            {
                Console.WriteLine("INGRESE NOMBRE:  ");
                String nombre = Console.ReadLine();
                Console.WriteLine("INGRESE CARNET:  ");
                String carnet = Console.ReadLine();


                Console.WriteLine("INGRESE EDAD:  ");
                int edad =Convert.ToInt32(Console.ReadLine());

               

                Console.WriteLine("¿ESTA SOLVENTE? INDIQUE:  ");
                Boolean solvente = Boolean.Parse(Console.ReadLine());

                Estudiante estudiante = new Estudiante(nombre,carnet,edad,  solvente);

                for(int x=0; x<2; x++){
                    Console.WriteLine("INGRESE EL CURSO:  ");
                    String curso = Console.ReadLine();

                    Console.WriteLine("INGRESE NOTA PRIMER PARCIAL:  ");
                    int N1 =Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("INGRESE NOTA SEGUNDO PARCIAL:  ");
                    int N2 =Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("NOTA FINAL:  ");
                    int NF =Convert.ToInt32(Console.ReadLine());
                    //int NF =Convert.ToInt32(Console.ReadLine());

                    notas note = new notas(curso,N1,N2,NF);
                    listadonotas[x]=note;

                }
                listadoestudiante[cont]=estudiante;
                cont++;
            }
            Console.WriteLine("\n"+"=======================LISTADO======================="+"\n");
            for(int i=0;i<2;i++){
                Estudiante estudiante = listadoestudiante[i];
                Console.WriteLine("NOMBRE:  " +estudiante.nombre+"\n"+  "CARNET:  " +estudiante.carnet+"   EDAD:  " +estudiante.edad+ "\n"+ "SOLVENTE:  "+estudiante.solvente);
                notas note = listadonotas[i];
                Console.WriteLine("CURSO:  " + note.curso);
                Console.WriteLine("NOTA PRIMER PARCIAL:  " + note.N1+"  NOTA SEGUNDO PARCIAL:  " + note.N2);
                Console.WriteLine("NOTA FINAL:  " + note.NF +"\n");

            }
        }      
    }
}
