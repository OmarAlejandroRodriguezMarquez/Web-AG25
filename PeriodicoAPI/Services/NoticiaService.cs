using Microsoft.EntityFrameworkCore;

public class NoticiaService : INoticiaService
{
    private readonly ApplicationDbContext context;

    public NoticiaService(ApplicationDbContext context)
    {
        this.context = context;
    }

    public async Task<Noticia> ActualizarNoticia(int id)
    {
        Noticia noticia = new Noticia();
        noticia = await context.Noticias.FirstOrDefaultAsync(n => n.Id == id);

        noticia.Titulo = "Noticia actualizada";
        noticia.Fecha = DateTime.Now;

        context.Noticias.Update(noticia);
        await context.SaveChangesAsync();
        return noticia;
    }

    public async Task<bool> EliminarNoticia(int id)
    {
        Noticia noticia = new Noticia();
        noticia = await context.Noticias.FirstOrDefaultAsync(n => n.Id == id);

        context.Noticias.Remove(noticia);
        var result = await context.SaveChangesAsync();
        if (result > 0)
        {
            return true;
        }
        return false;
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

    public async Task<Noticia> GuardarNoticiaDb(Noticia noticia)
    {
        context.Noticias.Add(noticia);
        await context.SaveChangesAsync();
        return noticia;
    }

    public async Task<Noticia> ObtenerNoticiaPorId(int id)
    {
        Noticia noticia = new Noticia();
        noticia = await context.Noticias.FirstOrDefaultAsync(n => n.Id == id);
        return noticia;
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