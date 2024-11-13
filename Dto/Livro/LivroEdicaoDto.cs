using WebApiLivros.Dto.Vinculo;
using WebApiLivros.Models;

namespace WebApiLivros.Dto.Livro
{
    public class LivroEdicaoDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public AutorVinculoDto Autor { get; set; }
    }
}
