namespace api_portafolio.entities.users;

public class Card
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
    private long idCard;
    public long IdCard
    {
        get
        {
            return this.idCard;
        }
        set
        {
            this.idCard = value;
        }
    }
    private string image;
    public string Image
    {
        get
        {
            return this.image;
        }
        set
        {
            this.image = value;
        }
    }
    private string description;
    public string Description
    {
        get
        {
            return this.description;
        }
        set
        {
            this.description = value;
        }
    }
    private string link;
    public string Link
    {
        get
        {
            return this.link;
        }
        set
        {
            this.link = value;
        }
    }
}
