using RedBubble.Application.DTOs.Design.DesignImages;

public class ArtistDesignDTO
{
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public ICollection<DesignImageDto> Images { get; set; } 
}
