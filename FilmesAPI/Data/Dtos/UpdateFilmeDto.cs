using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Data.Dtos
{
    public class UpdateFilmeDto
    {
        [Required(ErrorMessage = "O campo título é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo diretor é obrigatório")]
        public string Diretor { get; set; }
        [Required(ErrorMessage = "O campo genero é obrigatório")]
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "A diração deve ter no mínimo 1 e no máximo 600 minutos")]
        public int Duracao { get; set; }
        
    }
}
