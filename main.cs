using System;

class Program {
  public static void Main (string[] args) {
  
Double nfinal,n1,n2,n3,Mdexercicios;
String entrada;

Console.WriteLine ("Digite nota 1: ");
entrada = Console.ReadLine ();
n1 = Double.Parse(entrada);
    
Console.WriteLine ("Digite a nota 2:"); 
entrada = Console.ReadLine ();
n2 = Double.Parse(entrada);

Console.WriteLine ("Digite  a nota 3:");
entrada = Console.ReadLine ();
n3 = Double.Parse(entrada);
 
Console.WriteLine ("Digite a Media dos Exercicios");
entrada = Console.ReadLine ();
Mdexercicios = Double.Parse(entrada);

nfinal = (n1+2*n2+3*n3+ Mdexercicios) / 7;

if (nfinal >=9)

{Console.WriteLine ("Conceito A");
}
if (nfinal >=7.5 && nfinal <9)

{Console.WriteLine ("Conceito B");
}

if (nfinal >=6 && nfinal <7.5)

{Console.WriteLine ("Conceito C");
}
if (nfinal <6)
{
Console.WriteLine ("Conceito D");
}

  }
}