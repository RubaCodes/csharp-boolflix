using csharp_boolflix.Models;

namespace csharp_boolflix.Models
{
    public class MediaContent
    {
        public int Id { get; set; }
        public string Title { get; set; }
        //definita in minuti
        public int Durata { get; set; }
        public string Description { get; set; }
        public int VisualisationCount { get; set; }
    }
}

public class MediaInfo {
    public int MediaInfoId { get; set; }
    public string Year { get; set; }
    public bool IsNew { get; set; }

    public int MovieId { get; set; }
    public Movie Movie { get; set; }

    public int TvSeriesId { get; set; }
    public TvSeries Serie { get; set; }

}


public class TvSeries : MediaContent {
    public int SeasonsCount { get; set; }
    //public int EpisodesNumber { get; set; }
    MediaInfo? MediaInfo { get; set; }
}
public class Movie : MediaContent {
    public MediaInfo? MediaInfo { get; set; }
}
public class Episode : MediaContent {
    
    public int SeasonNumber { get; set; }

}