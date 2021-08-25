namespace LojaApp.Pages;

public partial class Somar
{
	private double nota1;
	private double nota2;
	private string? mensagem;

	private void Calcular()
	{
		double media = (nota1 + nota2) / 2;
		if (media >= 7)
			mensagem = $"Parabéns! Você foi aprovado com média {media}";
		else
			mensagem = $"Que pena! Você foi reprovado com média {media}";
	}
}
