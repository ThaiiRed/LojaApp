using LojaApp.Models;
using System.Collections.Generic;

namespace LojaApp.Pages;

public partial class Todo
{
	private List<TodoModel> todos = new();
	private string? novaTarefa;

	private void AdicionarTarefa()
	{
		if (!string.IsNullOrWhiteSpace(novaTarefa))
		{
			todos.Add(new TodoModel()
			{
				Titulo = novaTarefa
			});
			novaTarefa = "";
		}
	}

	private string FeitoStyle(bool feito)
	{
		return feito ? "font-style: italic;text-decoration: line-through;" : "";
	}
}
