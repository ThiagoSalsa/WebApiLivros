using WebApiLivros.Dto.Vinculo;
using WebApiLivros.Models;

namespace WebApiLivros.Dto.Livro
{
    public class LivroCriacaoDto
    {
        public string Titulo { get; set; }
        public AutorVinculoDto Autor { get; set; }
    }
}
