using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Core.Entities;

public class Response
{
    [Key]
    public int ID { get; set; }
    public string Name { get; set; } = "Anonymous";
    public string Comment { get; set; }
    public DateTime Time { get; set; }
    [JsonIgnore]
    public Fiber Fiber { get; set; }
}
