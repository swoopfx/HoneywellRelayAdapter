using System;
using System.ComponentModel.DataAnnotations;

namespace relayAdapter.Dtos
{
    public record Createpaymentdto
    {
        [Required]
        public string _custAccount { get; init; }

        [Required]
        public string _currencyCode { get; init; }

        [Required]
        public string _bankAccountId { get; init; }


        [Required]
        [Range(1, 1000000000000)]
        public decimal _amount { get; init; }

        public DateTimeOffset _date { get; init; }


    }
}