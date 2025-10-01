public interface INoticiaService
{
    //?Hardcodeado
    Task<Noticia> GuardarNoticia(Noticia noticia);
    Task<List<Noticia>> ObtenerNoticiasDb();
    Task<Noticia> GuardarNoticiaDb(Noticia noticia);
}