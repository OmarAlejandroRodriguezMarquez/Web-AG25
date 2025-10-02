public interface INoticiaService
{
    //?Hardcodeado
    Task<Noticia> GuardarNoticia(Noticia noticia);
    Task<List<Noticia>> ObtenerNoticiasDb();
    Task<Noticia> GuardarNoticiaDb(Noticia noticia);
    Task<Noticia> ObtenerNoticiaPorId(int id);
    Task<bool> EliminarNoticia(int id);
    Task<Noticia> ActualizarNoticia(int id);
}