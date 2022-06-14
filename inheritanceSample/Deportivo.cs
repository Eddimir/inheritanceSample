public class Deportivo : Auto{
    private string _color;
    public Deportivo(string marca, string color, int caballosFuerza)
       :base(marca,caballosFuerza)
    {
        this._color = color;
    }

    public override string ToString()
    {
        return string.Format("El carro de color "+_color+" y marca " + this.Marca + " tiene " + this.CaballosDeFuerza + " caballos de fuerza");
    }

    public override void Sonido()
    {
        System.Console.WriteLine("Bufffffffffffffff...!");
        base.Sonido();
    }
}