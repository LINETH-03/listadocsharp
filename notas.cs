using System;
namespace listado
{
    public class notas 
    {
       public string curso;
       public int N1, N2, N3, NF;
       
       public nota(string curso, int N1, int N2, int N3,  int NF) 
       {
           this.N1=N1;
           this.N2=N2;
           this.N3=N3;
           this.NF=NF;
       }
    }
}