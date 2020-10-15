using System;
// El metodo atacar deberia ser Virtual ya que los atauqes de los heroes afectan a los villanos y los de los villanos a los heroes. 
//Por lo tanto al ser ataques diferentes es mejor usar un metodo virtual ya que el contenidos de los metodos seran diferentes tambien.


namespace SuperHeroesTP
{
    class Program
    {
        static void Main(string[] args)
        {
            Villano Vil = new Villano();
            Superheroe Super = new Superheroe();
            Combate Comb = new Combate(Super,Vil,5);
            Super.Atacar(Vil);
            Vil.Atacar(Super);

        }
    }
}
