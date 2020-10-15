using System;


public class Villano:Personaje{
    public override void Atacar(Personaje p){
        base.Atacar(p);
        Console.WriteLine("El villano ataca al heroe.");
    }   
}