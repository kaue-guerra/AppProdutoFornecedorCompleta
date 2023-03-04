using Dev.Business.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dev.App.ViewModels
{
    public class SupplierViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        [DisplayName("Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(14, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 11)]
        [DisplayName("CPF/CNPJ")]
        public string Document { get; set; }

        [DisplayName("Tipo de Fornecedor")]
        public int SupplierType { get; set; }


        public AddressViewModel Address { get; set; }

        [DisplayName("Ativo?")]
        public bool Active { get; set; }

        [DisplayName("Produtos")]
        public IEnumerable<ProductViewModel> Products { get; set; }

    }
}
