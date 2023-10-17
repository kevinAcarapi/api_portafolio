using Microsoft.AspNetCore.Mvc;
using api_portafolio.entities.users;
using api_portafolio.dto.request;
using api_portafolio.dto.response;
using System.IO.Compression;

namespace api_portafolio.Controllers;

[ApiController]
[Route("[controller]")]
public class AboutMeController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<AboutMeController> _logger;

    public AboutMeController(ILogger<AboutMeController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetAboutMe")]
    /* PREGUNTAR SI VA PARAMETRO -> pero creo que no porque eso solo se hace en algùn tipo de paginaciòn o cuando se quiere buscar algo*/
    // public List<AboutMe> Get([FromQuery] AboutMeRequestDTO aboutMeRequestDTO)
    public List<AboutMeResponseDTO> Get()
    {

        List<AboutMe> AboutUs = new List<AboutMe>{};
        

        AboutMe aboutMe_miqueas = new AboutMe
        {
            Id = 1,
            About_me = "¡Hola! Soy programador, fiel cafetero... Nunca me quedo quieto, y menos cuando hay excelentes oportunidades para aprovecharlas. Actualmente desarrollo backend y bases de datos. Conozco y programo en los lenguajes de programación más conocidos: Java, C#, Python, JavaScript, Delphi y Haskell. Además, uso constantemente en proyectos HTML, CSS, Bootstrap, Angular y .NET. Mis estudios formales me abren grandes puertas, pero también ser autodidacta y la experiencia laboral me llevan a avanzar mucho más rápido. Espero haberles aclarado algunas dudas sobre mí.",
            Profile_photo= "https://media.licdn.com/dms/image/C4D22AQFQZrFQR6H54g/feedshare-shrink_1280/0/1664840869896?e=1700697600&v=beta&t=RqDcTuRYBcTfWslE3W378JBrEzZwI0wQtRUoe4yuq3c",
            //Habilidades tecnicas (todas las habilidades que conoce el usuario)
            Technologies = new List<string> {"Javascript", "Python", "C#", "Delphi", "Html", "Css"},
            Job_skills =  new List<string> {"Responsable", "Puntual", "Detallista", "Etc", "Etc", "Etc"}
        };
        AboutUs.Add(aboutMe_miqueas);

        List<AboutMeResponseDTO> listaRetorno = new List<AboutMeResponseDTO>();

        foreach (AboutMe aboutMe in AboutUs)
        {
            listaRetorno.Add( new AboutMeResponseDTO
            {
             Id = aboutMe_miqueas.Id,
             AboutMe = aboutMe_miqueas.About_me,
             Profile_photo = aboutMe_miqueas.Profile_photo,
             Technologies = aboutMe_miqueas.Technologies,
             Job_skills = aboutMe_miqueas.Job_skills
            });
        }

        // IEnumerable<AboutMe> listaFiltrada = AboutUs.Where( x => x.Id == aboutMeRequestDTO.Id);

        return listaRetorno.ToList<AboutMeResponseDTO>();
        
    }
}
