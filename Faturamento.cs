using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TesteTargetSistemas
{
    public class Faturamento
    {
        public int Dia { get; set; }
        public decimal Valor { get; set; }

		public void ResultadoFaturamento()
		{
			string jsonPath = "dados.json";

			// Deserializar o JSON para uma lista de objetos Faturamento
			string json = File.ReadAllText(jsonPath);
		
				List<Faturamento> faturamentos = JsonConvert.DeserializeObject<List<Faturamento>>(json);
				// Calcular a média, ignorando dias sem faturamento
				if(faturamentos == null)
				{
					Console.WriteLine("O arquivo JSON não é válido");
					return;
				}

				decimal soma = faturamentos.Where(x => x.Valor > 0).Sum(x => x.Valor);
				int diasComFaturamento = faturamentos.Count(x => x.Valor > 0);
				decimal media = diasComFaturamento > 0 ? soma / diasComFaturamento : 0;

				// Encontrar o menor e o maior valor
				decimal menorValor = faturamentos.Where(x => x.Valor > 0).Min(x => x.Valor);
				decimal maiorValor = faturamentos.Where(x => x.Valor > 0).Max(x => x.Valor);

				var menorData = faturamentos.First(x => x.Valor == menorValor);
				var maiorData = faturamentos.First(x => x.Valor == maiorValor);
				

			// Contar os dias com faturamento acima da média
				int diasAcimaDaMedia = faturamentos.Count(x => x.Valor > media);
				Console.WriteLine($"Menor valor: R$ {menorValor} no dia {menorData.Dia}");
				Console.WriteLine($"Maior valor: R$ {maiorValor} no dia {maiorData.Dia}");
				Console.WriteLine($"Número de dias com faturamento acima da média: {diasAcimaDaMedia}");
			
		}
	}

   
}
