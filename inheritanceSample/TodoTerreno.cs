
public class TodoTerreno:Auto
{
    private bool _Enceder4x4;
    public TodoTerreno(string marca, bool enceder4x4, int caballosFuerza):base(marca, caballosFuerza)
    {
        this._Enceder4x4 = enceder4x4;
    }

    public override string ToString()
    {
        return string.Format("El carro " + this.Marca + " que tiene " + this.CaballosDeFuerza + " caballos de fuerza, acaba de "+(this._Enceder4x4 ? "enceder" : "apagar")+" el 4x4 del vehiculo");
    }

    public override void Sonido(){
        System.Console.WriteLine("Brummmmmmmmmmmmmmmmmmmmmmmmmmmm...!");
        base.Sonido();

    }
}