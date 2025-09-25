
public class NoticiaService : INoticiaService
{
    private readonly ApplicationDbContext context;

    public NoticiaService(ApplicationDbContext context)
    {
        this.context = context;
    }
    public Task<Noticia> GuardarNoticia(Noticia noticia)
    {
        Noticia nuevaNoticia = new Noticia();
        nuevaNoticia.Titulo = "Impuestos a los videojuegos";
        nuevaNoticia.Contenido = "El gobierno ha decidido implementar nuevos impuestos a los videojuegos del 8% cuando son violentos";
        nuevaNoticia.Fecha = DateTime.Now;

        context.Noticias.Add(nuevaNoticia);
        context.SaveChanges();

        return Task.FromResult(nuevaNoticia);
    }
}