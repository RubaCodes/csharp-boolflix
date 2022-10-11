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

    public int? MovieId { get; set; }
    public Movie Movie { get; set; }

    public int? TvSeriesId { get; set; }
    public TvSeries Serie { get; set; }
    public List<Actor> Cast { get; set; }

    public List<Genre> Genres { get; set; }
    public List<Feature> Features { get; set; }


}


public class TvSeries : MediaContent {
    public int SeasonsCount { get; set; }
    //public int EpisodesNumber { get; set; }
    MediaInfo? MediaInfo { get; set; }
    public List<Episode> Episodes { get; set; }
}
public class Movie : MediaContent {
    public MediaInfo? MediaInfo { get; set; }
}
public class Episode : MediaContent {
    
    public int SeasonNumber { get; set; }
    public int TvSeriesId { get; set; }
    public TvSeries TvSerie { get; set; }

}


public class Actor {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public List<MediaInfo> MediaInfos { get; set; }



}

public class Genre
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<MediaInfo> MediaInfos { get; set; }


}

public class Feature
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<MediaInfo> MediaInfos { get; set; }
}