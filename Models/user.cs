using System.ComponentModel.DataAnnotations;

namespace UserManagementApi.Models {
    public class User {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome é obrigatório")]
        public string Name { get; set; }
        [Required, EmailAddress(ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }
    }
}