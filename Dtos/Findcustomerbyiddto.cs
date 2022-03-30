using System.ComponentModel.DataAnnotations;

namespace relayAdapter.Dtos
{

    public record Findcustomerbyiddto{
        
         [Required]
        //  [Range(10, 10)]
        public string _custAccount { get; init; }
    }
    
}