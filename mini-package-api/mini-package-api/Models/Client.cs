using mini_package_api.Enums;
using System.Text.Json.Serialization;

namespace mini_package_api.Models
{
    public class Client : User
    {
        public new UserRoleEnum Role
        {
            get { return UserRoleEnum.Client; }
            set { }
        }

        public virtual List<ClientAddress> ClientAddresses { get; set; }

        public bool Newsletter { get; set; }

        public Client()
        {

        }

    }
}
