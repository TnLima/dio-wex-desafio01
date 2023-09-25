namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        string ultimaPlacaRemovida = "";
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placaInicial = Console.ReadLine();
            //veiculos.Add(Console.ReadLine());

            if (veiculos.Any(x => x.ToUpper() == placaInicial.ToUpper()))
            {
                Console.WriteLine($"Erro: Placa já registrada!");
            }
            else
            {
                veiculos.Add(placaInicial);
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*

            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                bool sucesso = false;
                int horas = 0;
                do
                {
                    try
                    {
                        horas = Convert.ToInt32(Console.ReadLine());
                        sucesso = true;
                    }
                    catch
                    {
                        Console.WriteLine("Insira apenas números!");
                        sucesso = false;
                    }
                } while (!sucesso);

                decimal valorTotal = precoInicial + (precoPorHora * horas);
                for (int i = 0; i < veiculos.Count; i++)
                {
                    if (veiculos[i] == placa)
                    {
                        veiculos.Remove(placa);
                        ultimaPlacaRemovida = placa;
                    }
                }

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*


                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                if (placa == ultimaPlacaRemovida)
                {
                    Console.WriteLine("Placa já removida anteriormente");

                }
                else
                {
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");

                }
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                for (int i = 0; i < veiculos.Count; i++)
                {
                    Console.WriteLine(veiculos[i]);
                }
                // *IMPLEMENTE AQUI*
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
