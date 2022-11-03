using System.ComponentModel.DataAnnotations;

namespace Quadro_Operacional.Models
{
    public class Quadro
    {
        public string? Operacao { get; set; }
        [Key]
        public int Matricula { get; set; }
        public string? Funcionario { get; set; }
        public string? Onda { get; set; }
        public string? Ps { get; set; }
        public int? Logid { get; set; }
        public string? Situacao { get; set; }
        public string? Celula { get; set; }
        public string? Coordenador { get; set; }
        public string? Supervisor { get; set; }
        public DateTime? Dt_Admissao { get; set; }
        public string? Funcao { get; set; }
        public TimeSpan? Entrada { get; set; }
        public TimeSpan? Saida { get; set; }
        public TimeSpan? Intervalo { get; set; }
        public DateTime? Dt_Desligamento { get; set; }
        public string? Genero { get; set; }
        public string? Estado_Civil { get; set; }
        public string? Escolaridade { get; set; }
        public DateTime? Dt_Nascimento { get; set; }
        public double? Cpf { get; set; }
        public double? Rg { get; set; }
        public string? Uf { get; set; }
        public string? Cidade { get; set; }
        public string? Bairro { get; set; }
        public string? Celular { get; set; }
        public DateTime? Dt_Experiencia { get; set; }
        public DateTime? Dt_Experiencia_Pg { get; set; }
        public DateTime? Dt_Contrato_Temp { get; set; }
        public DateTime? Dt_Ferias { get; set; }
        public DateTime? Dt_Ferias_Fim { get; set; }
    }
}
