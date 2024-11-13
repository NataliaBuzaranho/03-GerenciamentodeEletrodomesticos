namespace _03_GerenciamentodeEletrodomesticos.Models
{
    public class Televisor : Eletrodomestico
    {
            public int TamanhoTela { get; set; }
            public bool EhSmart { get; set; }

            public override string ExibirDetalhes()
            {
            return $"Marca: {Marca}, Modelo: {Modelo}, Consumo: {ConsumoEnergetico} kWh, Tela: {TamanhoTela}”, É Smart: {(EhSmart ? "Sim" : "Não")}";

        }
    }
}
