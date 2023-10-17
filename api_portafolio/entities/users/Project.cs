namespace api_portafolio.entities.users;

public class Project
{
    private User id;
    public User Id
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
    private long idProject;
    public long IdProject
    { 
        get
        {
            return this.idProject;
        }
        set
        {
            this.idProject = value;
        } 
    }
    private List<string>technologiesUsed;
    public List<string>TechnologiesUsed
    { 
        get
        {
            return this.technologiesUsed;
        }
        set
        {
            this.technologiesUsed = value;
        } 
    }
    private string drafting;
    public string Drafting
    { 
        get
        {
            return this.drafting;
        }
        set
        {
            this.drafting = value;
        } 
    }
    private string title;
    public string Title
    { 
        get
        {
            return this.title;
        }
        set
        {
            this.title = value;
        } 
    }
    private string projectLink;
    public string ProjectLink
    { 
        get
        {
            return this.projectLink;
        }
        set
        {
            this.projectLink = value;
        } 
    }
}