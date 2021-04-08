using System;

namespace listado
{
    class Program
    {
        static void Main(String [] args){
            //String[] Estudiante = new string[2];
            Estudiante[] listadoestudiante = new Estudiante[2];
            //String[] notas = new string[2];
            notas[] listadonotas = new notas[2];
            int cont = 0;

            while (cont < 2)
            {
                Console.WriteLine("INGRESE NOMBRE:  ");
                String nombre = Console.ReadLine();


                Console.WriteLine("INGRESE EDAD:  ");
                int edad =Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("INGRESE CARNET:  ");
                String carnet = Console.ReadLine();

                Console.WriteLine("¿ESTA SOLVENTE? INDIQUE:  ");
                Boolean solvente = Boolean.Parse(Console.ReadLine());

                
                Estudiante estudent = new Estudiante(nombre,edad,carnet,solvente);

                for(int x=0; x<2; x++){
                    Console.WriteLine("INGRESE EL CURSO:  ");
                    String curso = Console.ReadLine();

                    Console.WriteLine("INGRESE NOTA PRIMER PARCIAL:  ");
                    int N1 =Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("INGRESE NOTA SEGUNDO PARCIAL:  ");
                    int N2 =Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" NOTA FINAL:  ");
                    int NF =Convert.ToInt32(Console.ReadLine());

                    notas note = new notas(curso,N1,N2,NF);
                    listadonotas[x]=note;

                }
                listadoestudiante[cont]=estudent;
                cont++;
            }
            Console.WriteLine("\n"+"LISTADO");
            for(int i=0;i<2;i++){
                Estudiante estudent = listadoestudiante[i];
                Console.WriteLine("NOMBRE:  " +estudent.nombre+"   CARNET:  " +estudent.carnet+"   EDAD:  " +estudent.edad+ "\n"+ "SOLVENTE:  "+estudent.solvente);
                

                for(int j=0; j<2; j++){
                    notas note = listadonotas[j];
                    Console.WriteLine("CURSO:  " + note.curso);
                    Console.WriteLine("NOTA PRIMER PARCIAL:  " + note.N1+"NOTA SEGUNDO PARCIAL:  " + note.N2);
                    Console.WriteLine("NOTA FINAL:  " + note.NF +"\n");
                }
            }



        }
       
    }
}
