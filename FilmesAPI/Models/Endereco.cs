using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Endereco
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        //public int CinemaId { get; set; }//nao precisa do Id do cinema pq um endereco pode existir sem um cinema
        public virtual Cinema Cinema{ get; set; }//relacao 1:1 com endereco

    }
}