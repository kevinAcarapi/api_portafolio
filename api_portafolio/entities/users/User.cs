namespace api_portafolio.entities.users;

public class User
{
    private long id;
    public long Id
    {
        get
        {
            return this.id;
        }
        set
        {
            this.id = value;
        }
    }
    private string email;
    public string Email
    {
        get
        {
            return this.email;
        }
        set
        {
            this.email = value;
        }
    }
    private string name;
    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            this.name = value;
        }
    }
    private string surname;
    public string Surname
    {
        get
        {
            return this.surname;
        }
        set
        {
            this.surname = value;
        }
    }
    private string password;
    public string Password
    {
        get
        {
            return this.password;
        }
        set
        {
            this.password = value;
        }
    }
    private bool active;
    public bool Active
    {
        get
        {
            return this.active;
        }
        set
        {
            this.active = value;
        }
    }
    private string profession;
    public string Profession
    {
        get
        {
            return this.profession;
        }
        set
        {
            this.profession = value;
        }
    }
    private string linkedin;
    public string Linkedin
    {
        get
        {
            return this.linkedin;
        }
        set
        {
            this.linkedin = value;
        }
    }
    private string facebook;
    public string Facebook
    {
        get
        {
            return this.facebook;
        }
        set
        {
            this.facebook = value;
        }
    }
    private string instagram;
    public string Instagram
    {
        get
        {
            return this.instagram;
        }
        set
        {
            this.instagram = value;
        }
    }
    private string gitHub;
    public string GitHub
    {
        get
        {
            return this.gitHub;
        }
        set
        {
            this.gitHub = value;
        }
    }
    private string cv;
    public string Cv
    {
        get
        {
            return this.cv;
        }
        set
        {
            this.cv = value;
        }
    }
    private List<Project> project;
    public List<Project> Project 
    {
        get
        {
            return this.project;
        }  
        set 
        {
            this.project = value;
        }
    }
    private List<AboutMe> skill;
    public List<AboutMe> Skill 
    {
        get
        {
            return this.skill;
        }  
        set 
        {
            this.skill = value;
        }
    }
    private List<Card> card;
    public List<Card> Card 
    {
        get
        {
            return this.card;
        }  
        set 
        {
            this.card = value;
        }
    }

}


