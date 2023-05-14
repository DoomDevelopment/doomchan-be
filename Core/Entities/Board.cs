using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Core.Entities;

public class Board
{
    [Key]
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Type { get; set; }
    [JsonIgnore]
    public List<Fiber> Fibers { get; set; }
}
