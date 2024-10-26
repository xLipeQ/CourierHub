using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace mini_package_api.Models
{
    public class ClientAddress
    {
        public int Id { get; set; }

        public int ClientId { get; set; }

        public virtual Client Client{ get; set; }

        public int AddressId { get; set; }

        public virtual Address Address { get; set; }

        public bool IsDefault { get; set; }

        public virtual List<Inquire> SourceInquires { get; set; }

        public virtual List<Inquire> DestinationInquires { get; set; }
    }
}
