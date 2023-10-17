namespace api_portafolio.entities.users;

public class AboutMe
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
    private string about_me;
    public string About_me 
    {
        get 
        {
            return this.about_me;
        }
        set
        {
            this.about_me = value;
        } 
    }
    private string profile_photo;
    public string Profile_photo 
    { 
        get
        {
            return this.profile_photo;
        } 
        set
        {
            this.profile_photo = value;
        }
    }
    private List<string> technologies;
    public List<string> Technologies 
    {
        get
        {
            return this.technologies;       
        }
        set
        {
            this.technologies = value;
        }
    }
    private  List<string> job_skills;
    public List<string> Job_skills  
    {
        get
        {
            return this.job_skills;       
        }
        set
        {
            this.job_skills = value;
        }
    }

    
}
