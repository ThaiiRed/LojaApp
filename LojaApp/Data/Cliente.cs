using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LojaApp.Data;

public class Cliente
{
    /*Criar a tabela de clientes com os seguintes campos: Id, Nome, Cpf, Telefone, Email, Sexo, Estado Civil, 
     * Escolaridade, Data de Nascimento e Endereço.*/
    public int Id {  get; set; }
    public string? Nome {  get; set; }
    [MaxLength(11)]
    public int Cpf {  get; set; }
    [MaxLength(11)]
    public int Telefone {  get; set; }
    [Required]
    public string? Email {  get; set; }
    public string? Sexo { get; set; }
    public string? EstadoCivil { get; set; }
    public string? Escolaridade { get; set; }
    public string? DataDeNascimento { get; set; }

    [StringLength(255)]
    public string? Endereco { get; set; }

}

