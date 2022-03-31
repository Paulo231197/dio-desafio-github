using JOGO_RPG.src;

namespace JOGO_RPG
{
    class Program{
         static void Main(String[] args){
               Knight Arus = new Knight("Arus", 42, "Knight");
               Knight Wedge = new Knight();
               Wizard Jennica = new Wizard("Jennica", 42, " White Wizard");
               Wizard Topapa = new Wizard("Topapa", 42, "Black Wizard");

               Wedge.Name = "Wedge";
               Wedge.Level = 42;
               Wedge.HeroType = "Ninja";

               Console.WriteLine(Arus); // toda vez que uma classe é chamada por leitura, é considerado o método toString() para realizar esta leitura.
               Console.WriteLine(Wedge);
               Console.WriteLine(Jennica);
               Console.WriteLine(Topapa);

                Console.WriteLine(Arus.Attack());
                Console.WriteLine(Wedge.Attack());
                Console.WriteLine(Jennica.Attack(3));
                Console.WriteLine(Topapa.Attack(7));

    }
  }
}