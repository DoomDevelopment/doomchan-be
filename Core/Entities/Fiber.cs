using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Core.Entities;

public class Fiber
{
    [Key]
    public int ID { get; set; }
    // public byte[] Image { get; set; }
    public string Name { get; set; } = "";//tripfag
    public string Subject { get; set; }
    public string Comment { get; set; }
    public DateTime Time { get; set; }
    [JsonIgnore]
    public List<Response> Responses { get; set; } = new List<Response>();
    [JsonIgnore]
    public Board Board { get; set; }
}