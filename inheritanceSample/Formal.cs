public class Formal :Auto{    
    public Formal(string marca, int caballosfuerza) : base(marca,50)
    { }

    public override void Sonido()
    {
        System.Console.WriteLine("ummmmmmmmmmmmmmmmmmm.!!!");
        base.Sonido();
    }

}