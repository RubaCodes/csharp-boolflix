using csharp_boolflix.Models;

public class Movie : MediaContent {
    public MediaInfo? MediaInfo { get; set; }

    public Movie() {
        MediaInfo = new MediaInfo();
    }
}
