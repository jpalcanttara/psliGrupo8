using Microsoft.AspNetCore.Identity;

namespace PUC.LDSI.Identity.Entities
{
    public class Usuario : IdentityUser
    {
        [PersonalData]
        public int IntegrationId { get; set; }
        public int UserType { get; set; }
    }
}