using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("news")]
public class NoticiasController : ControllerBase
{
    private readonly INoticiaService noticiaService;

    public NoticiasController(INoticiaService noticiaService)
    {
        this.noticiaService = noticiaService;
    }

    [HttpGet]
    public Noticia ObtenerNoticia()
    {
        Noticia noticia = new Noticia();
        noticia.Id = 1;
        noticia.Titulo = "Mundial 2026";
        noticia.Contenido = "El mundial se llevará a cabo en México, USA, Canadá";
        noticia.Fecha = DateTime.Now;

        return noticia;
    }

    [HttpGet("financiera")]
    public Noticia ObtenerNoticiaFinanciera()
    {
        Noticia noticia = new Noticia();
        noticia.Id = 2;
        noticia.Titulo = "Dolar vs Peso";
        noticia.Contenido = "El peso se muestra fuerte";
        noticia.Fecha = DateTime.Now;

        return noticia;
    }

    [HttpGet("nueva")]
    public Noticia NoticiaNueva()
    {
        var nuevaNoticia = noticiaService.GuardarNoticia(new Noticia());
        return nuevaNoticia.Result;
    }

    [HttpGet("basedatos")]
    public async Task<List<Noticia>> NoticiasDb()
    {
        var noticias = await noticiaService.ObtenerNoticiasDb();
        return noticias;
    }

    [HttpPost("guardarnoticia")]
    public async Task<Noticia> GuardarNoticia([FromBody] Noticia noticia)
    {
        var nuevaNoticia = await noticiaService.GuardarNoticiaDb(noticia);
        return nuevaNoticia;
    }
}