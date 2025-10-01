public interface INoticiaService
{
    Task<Noticia> GuardarNoticia(Noticia noticia);
    Task<List<Noticia>> ObtenerNoticiasDb();
}