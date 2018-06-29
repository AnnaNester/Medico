using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Medico
    {
        [Key]
        public string crm { get; set; }

        [Required, StringLength(50)]
        public string nome { get; set; }

        public string endereco { get; set; }

        [Required, StringLength(50)]
        public string especialidade { get; set; }

    }
}
