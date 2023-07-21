using System;

public class Pessoa
{
	private int anoNascimento;

	public int AnoNascimento
	{
		get { return this.anoNascimento; }
		set { this.anoNascimento= value; }
	}
	private string nome ="";

	public string Nome
	{
		get { return this.nome; }
		set { this.nome = value; }
	}

	private int calculaIdade()
	{	
		//calcula a idade
		DateTime data =	DateTime.Now;
		int ano = data.Year;
		int idade = ano - this.anoNascimento;
		return idade;
	}
	public void exibirDados()
	{
		Console.WriteLine("Nome: "+this.Nome.ToUpper());
		Console.WriteLine("Ano de Nascimento: "+this.anoNascimento);
		Console.WriteLine("idade: " + calculaIdade());
	}

}
