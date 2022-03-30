using System.ComponentModel.DataAnnotations;

namespace relayAdapter.Dtos
{

    public record Findcustomerbyiddto{
        
         [Required]
        public string _custAccount { get; init; }
    }
    
}