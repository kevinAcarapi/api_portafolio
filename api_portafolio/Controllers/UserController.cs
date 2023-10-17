using Microsoft.AspNetCore.Mvc;
using api_portafolio.entities.users;
using api_portafolio.dto.request;

/*
using System.Reflection.Metadata;
using Microsoft.AspNetCore.Components.Web;
*/

namespace api_portafolio.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<UserController> _logger;

    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetUser")]
    public List<User> Get([FromQuery] UserRequestDTO userRequestDTO)
    {
        List<User> users = new List<User>();

        List<Project> projects = new List<Project>{};

        List<Card> projectsCards = new List<Card>{};
        
        List<AboutMe> AboutUs = new List<AboutMe>{};
        

        AboutMe aboutMe_miqueas = new AboutMe
        {
            Id = 1,
            About_me = "¡Hola! Soy programador, fiel cafetero... Nunca me quedo quieto, y menos cuando hay excelentes oportunidades para aprovecharlas. Actualmente desarrollo backend y bases de datos. Conozco y programo en los lenguajes de programación más conocidos: Java, C#, Python, JavaScript, Delphi y Haskell. Además, uso constantemente en proyectos HTML, CSS, Bootstrap, Angular y .NET. Mis estudios formales me abren grandes puertas, pero también ser autodidacta y la experiencia laboral me llevan a avanzar mucho más rápido. Espero haberles aclarado algunas dudas sobre mí.",
            //Habilidades tecnicas (todas las habilidades que conoce el usuario)
            Technologies = new List<string>{"Javascript", "Python", "C#", "Html", "Css"},
            Job_skills =  new List<string>{"Responsable", "Puntual", "Detallista"}
        };
        AboutUs.Add(aboutMe_miqueas);

        Project calculator = new Project 
        {
            /* -> falta el primer Id de la clase "users"*/
            IdProject = 1,
            //Tecnologias utilizadas en el proyecto
            TechnologiesUsed = new List<string>{"Javascript", "Html", "Css"},
            Drafting = "App que permite relizar operaciones matematicas",
            Title = "Calculadora",
            ProjectLink = "Link de proyecto calculadora",
        };
        projects.Add(calculator);

        /*
        Project project_1 = new Project
        {
            /* -> falta el primer Id de la clase "users"
            //Id = idUser,
            IdProject = 1,
            TechnologiesUsed = "Python, Javascript",
            Drafting = "Obtendras la hora exacta de la forma más divertida.",
            Title = "Calculadora",
            ProjectLink = "Link de proyecto"
        };
        */
        Card card_1 = new Card
        {
            /* -> falta el primer Id de la clase "users"*/
            //Id = idUser,
            IdCard = 1,
            Image = "Imagen de proyecto calculadora",
            Description = "Descripción del proyecto calculadora",
            Link = "Link del proyecto calculadora",
        };
        projectsCards.Add(card_1);

        User miqueas = new User{
            Id = 1,
            Email = "miqueas.drovetta@itscordoba.edu.ar",
            Name = "Miqueas",
            Surname = "Drovetta",  
            Password = "12AS34df",
            Active = true,
            Profession = "Desarrollo de Software",
            Linkedin = "www.linkedin.com/usuario",
            Facebook = "www.facebook.com/usuario",
            Instagram = "www.instagram.com/usuario",
            GitHub = "www.github.com/usuario",
            Cv = "link de curriculum",
            Project = projects,
            Skill = AboutUs,
            Card = projectsCards
        };

        users.Add(miqueas);

        /* SEGUNDO USUARIO */

        AboutMe aboutMe_kevin = new AboutMe
        {
            Id = 2,
            About_me = "Soy un estudiante dedicado y entusiasta con un fuerte interés en el desarrollo de software. Actualmente, me encuentro ampliando mis conocimientos a través de cursos de Desarrollo Web mientras continuo mi carrera. Mi compromiso con el aprendizaje continuo me impulsan a seguir creciendo y contribuyendo en este apasionante campo.",
            //Habilidades tecnicas (todas las habilidades que conoce el usuario)
            Technologies = new List<string>{"Javascript", "Python", "C#", "Html", "Css"},
            Job_skills =  new List<string>{"Responsable", "Puntual", "Detallista"}
        };
        AboutUs.Add(aboutMe_kevin);

        Project clock = new Project 
        {
            /* -> falta el primer Id de la clase "users"*/
            IdProject = 1,
            //Tecnologias utilizadas en el proyecto
            TechnologiesUsed = new List<string>{"Javascript", "Html", "Css"},
            Drafting = "App que muestra la hora, minutos y segundos.",
            Title = "Reloj",
            ProjectLink = "Link de proyecto Reloj",
        };
        projects.Add(clock);

        /*
        Project project_1 = new Project
        {
            /* -> falta el primer Id de la clase "users"
            //Id = idUser,
            IdProject = 1,
            TechnologiesUsed = "Python, Javascript",
            Drafting = "Obtendras la hora exacta de la forma más divertida.",
            Title = "Calculadora",
            ProjectLink = "Link de proyecto"
        };
        */
        Card card_clock = new Card
        {
            /* -> falta el primer Id de la clase "users"*/
            //Id = idUser,
            IdCard = 1,
            Image = "Imagen de proyecto reloj",
            Description = "Descripción del proyecto reloj",
            Link = "Link del proyecto reloj",
        };
        projectsCards.Add(card_clock);

        User kevin = new User{
            Id = 2,
            Email = "kevin.acarapi@itscordoba.edu.ar",
            Name = "kevin",
            Surname = "Acarapi",  
            Password = "12AS34df",
            Active = true,
            Profession = "Desarrollo de Software",
            Linkedin = "www.linkedin.com/usuario",
            Facebook = "www.facebook.com/usuario",
            Instagram = "www.instagram.com/usuario",
            GitHub = "www.github.com/usuario",
            Cv = "link de curriculum",
            Project = projects,
            Skill = AboutUs,
            Card = projectsCards
        };

        users.Add(kevin);

        IEnumerable<User> listaFiltrada = users.Where( x => x.Id == userRequestDTO.Id);

        return listaFiltrada.ToList<User>();

    }
}
