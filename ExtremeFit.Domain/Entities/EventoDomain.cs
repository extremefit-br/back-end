using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExtremeFit.Domain.Entities
{
    public class EventoDomain : BaseDomain
    {
        [Required]
        [DataType(DataType.Text)]
        public string Descricao { get; set; }

        [ForeignKey("UnidadeFavoritaId")]
        public UnidadeSesiDomain Unidade { get; set; }
        public int UnidadeFavoritaId { get; set; }

        [ForeignKey("UsuarioId")]
        public UsuarioDomain Usuario { get; set; }
        public int UsuarioId { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DataEvento { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DataAlteracao { get; set; }
    }
}