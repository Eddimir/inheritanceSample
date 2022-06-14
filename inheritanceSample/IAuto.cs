public interface IAuto
{
    void Encender();
    void Apagar();
    bool IsEncendido{ get;}
    int CalculaVelocidadPorSegundo();
}
