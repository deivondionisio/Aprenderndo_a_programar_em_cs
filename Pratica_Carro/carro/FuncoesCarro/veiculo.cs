namespace carro.FuncoesCarro
{
    public class Veiculo
    {
        public int NivelCombustivel { get; set; }
        public bool Ligado { get; set; }
        public void Ligar() => Ligado = true;
        public void Desligar() => Ligado = false;
        public string Buzinar() => Ligado;
    }
}

public class Moto : Veiculo
{
    public override string Buzinar()
    {
        return "Bi-Bi";
    }
}