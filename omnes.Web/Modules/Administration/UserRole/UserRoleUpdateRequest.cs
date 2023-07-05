using Serenity.Services;
using System.Collections.Generic;

namespace omnes.Administration
{
    public class UserRoleUpdateRequest : ServiceRequest
    {
        public int? UserID { get; set; }
        public List<int> Roles { get; set; }
    }
}