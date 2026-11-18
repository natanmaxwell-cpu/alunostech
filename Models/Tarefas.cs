
using System.ComponentModel.DataAnnotations;

namespace AlunosTech.Models
{
    public class Tarefa
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o título da tarefa.")]
        public string Titulo { get; set; } = string.Empty;

        public string? Descricao { get; set; }

        public string Status { get; set; } = "Pendente";
    }
}
