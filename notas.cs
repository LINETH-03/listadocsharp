using System;

namespace listado
{
    public class notas 
    {
       public String curso;
       public int N1, N2,  NF;

       public notas(String curso, int N1, int N2,  int NF) 
       {
           this.curso=curso;
           this.N1=N1;
           this.N2=N2;
           this.NF=NF;
       }
    }
}