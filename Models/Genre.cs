using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


[Index(nameof(Genre.Name), IsUnique = true)]
public class Genre
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<MediaInfo> MediaInfos { get; set; }

    public Genre() {
        MediaInfos = new List<MediaInfo>();
    }
}
