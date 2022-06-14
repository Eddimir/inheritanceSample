public class Auto:IAuto
{
    protected int CaballosDeFuerza;
    private bool _isecendido;
    public readonly string Marca;

    public Auto(string marca, int caballosDeFuerza)
    {
        this.Marca = marca;
        this.CaballosDeFuerza = caballosDeFuerza;
    }

    public void Encender(){
        System.Console.WriteLine($"El auto de marca {this.Marca}, se esta ecendiendo...");
        _isecendido = true;
    }

    public void Apagar(){
        System.Console.WriteLine($"Ël auto de marca {this.Marca}, se esta apagando...");
        _isecendido = false;
    }

    public int CalculaVelocidadPorSegundo()
    {
        return (this.CaballosDeFuerza * 60) * 2;
    }

    public bool IsEncendido {
        get{
            return _isecendido;
        }
    }
    public virtual void Sonido(){
        System.Console.WriteLine("Sonido genirico de auto,  "+this.Marca+"");
    }


}
