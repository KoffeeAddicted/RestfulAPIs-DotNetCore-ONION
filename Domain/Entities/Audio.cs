using Domain.Entities;

namespace Domain;

public class Audio : DeleteEntity<Int64>
{
    public Int64 EpisodeId { get; set; }
    public String Link { get; set; } = String.Empty;
    public virtual Episode Episode { get; set; }
    public Int64 Duration { get; set; }
    
    public AudioState State { get; set; }
}