using System;



public class Superheroe:Personaje{

    #region Atributos

    private int CantidadVidas;
    private Superpoder Superpoder;

 

    #endregion
    
    #region Constructor
    public Superheroe():base(){
        this.CantidadVidas = 2;
        this.Superpoder = new Superpoder();
       
    }

    public Superheroe(int CantVidas, Superpoder super, string nom, int anio, string univ, int stam):base(nom,anio,univ,stam){
        this.CantidadVidas = CantVidas;
        this.Superpoder = super;
    }
    #endregion

    #region setters y getters
    //set
    public void SetCantidadVidas(int valor){
        this.CantidadVidas = valor;
    }

    public void SetSuperpoder(Superpoder valor){
        this.Superpoder = valor;
    }
    //get
    public int GetCantidadVidas(){
        return this.CantidadVidas;
    }
    
    public Superpoder GetSuperpoder(){
        return this.Superpoder;
    }
    #endregion

    #region metodos

    public Item ObtenerItem(){
        return new Item();
    }
    public void Usar(Item item){
        
    }
    public void Usar(int ataque){
        
    }
    public void Usar(Superpoder s){
        
    }
    public override void Atacar(Personaje p, Superpoder s){
        base.Atacar(p);
        Console.WriteLine("El heroe ataca al villano.");
        this.Usar(s);
    }

    #endregion
}