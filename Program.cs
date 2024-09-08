using TesteTargetSistemas;
#region Exercicio 1
//int indice = 13;
//int soma = 0;
//int k = 0;

//while(k < indice)
//{
//	k = k + 1;
//	soma = soma + k;
//}
//Console.WriteLine(soma);
#endregion
#region Exercicio 2
//Console.WriteLine("Insira um valor");
//var inputValue = Console.ReadLine();

//if (inputValue != null)
//{
//	if (inputValue.All(char.IsDigit))
//	{
//		int value = Convert.ToInt32(inputValue);
//		int a = 0;
//		int b = 1;

//		while (b < value)
//		{
//			int temp = a;
//			a = b;
//			b = temp + b;
//		}

//		if (b == value)
//		{
//			Console.WriteLine($"O número {value} pertence a sequência de Fibonacci");
//		}
//		else
//		{
//			Console.WriteLine($"O número {value} não pertence a sequência de Fibonacci");
//		}
//	}
//	else
//	{
//		Console.WriteLine("Insira apenas números");
//		return;
//	}
//}
//else
//{
//	Console.WriteLine("O número inserido näo é válido");
//	return;
//}
#endregion
#region Exercicio 3
//Faturamento faturamento = new Faturamento();

//faturamento.ResultadoFaturamento();
#endregion
#region Exercicio 4	

//double[] faturamento = { 67836.43, 36678.66, 29229.88, 27165.48, 19849.53 };
//double valorTotal = faturamento.Sum();

//Console.WriteLine($"Faturamento Mensal de SP: R${faturamento[0]}");
//Console.WriteLine($"Faturamento Mensal de RJ: R${faturamento[1]}");
//Console.WriteLine($"Faturamento Mensal de MG: R${faturamento[2]}");
//Console.WriteLine($"Faturamento Mensal de ES: R${faturamento[3]}");
//Console.WriteLine($"Faturamento Mensal de outros estados: R${faturamento[4]}");
//Console.WriteLine($"Faturamento total: R${valorTotal}");
//Console.WriteLine("\n");

//List<double> percentual = [];

//for(int i = 0; i< faturamento.Length; i++)
//{
//	percentual.Add(faturamento[i] / valorTotal * 100);
//}
//Console.WriteLine($"Percentual de SP: {percentual[0]:F2}%");
//Console.WriteLine($"Percentual de RJ: {percentual[1]:F2}%");
//Console.WriteLine($"Percentual de MG: {percentual[2]:F2}%");
//Console.WriteLine($"Percentual de ES: {percentual[3]:F2}%");
//Console.WriteLine($"Percentual de outros estados: {percentual[4]:F2}%");

#endregion
#region Exercicio 5
//Console.WriteLine("Insira um texto: ");
//var texto = Console.ReadLine();
//string textoInvertido = "";

//if (texto == null) {
//	Console.WriteLine("Insira um texto válido");
//	return;
//}
//else
//{
//	for (int i = texto.Length - 1; i >= 0; i--)
//	{
//		textoInvertido += texto[i];
//	}

//	Console.WriteLine(textoInvertido);
//}
#endregion