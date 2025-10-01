using Microsoft.EntityFrameworkCore;

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

    //!Método asíncrono
    public async Task<List<Noticia>> ObtenerNoticiasDb()
    {
        //?Creamos una lista vacía
        List<Noticia> noticias = new List<Noticia>();

        //?Obtenemos las noticias de la base de datos
        noticias = await context.Noticias.ToListAsync();

        //?Devolvemos la lista de noticias
        return noticias;
    }
}