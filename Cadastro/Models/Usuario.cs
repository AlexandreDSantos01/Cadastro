using System.ComponentModel.DataAnnotations;

namespace Cadastro.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        [Required(ErrorMessage = " O nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "A data de nascimento é obrigatório")]
        public DateTime DataNasc { get; set; }
        public enum Sexo
        {
            Masculino,
            Feminino,
            Outros,
            NaoInformar
        }
        public Sexo TipoSexo { get; set; }
        [Required(ErrorMessage = "O email é obrigatório")]
        [EmailAddress(ErrorMessage = "O email não é valido")]
        public string Email { get; set; }
        [Required(ErrorMessage = " O Endereço é obrigatorio")]
        public string Endereco { get; set; }
        [Required(ErrorMessage = "O numero da rua é obrigatorio")]
        public int NRua { get; set; }
    }
}
