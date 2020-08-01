using System.Collections.Generic;

namespace DevIO.Api.ViewModels.Identity
{
    public class UserTokenViewModel
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public IEnumerable<ViewModels.ClaimViewModel> Claims { get; set; }
    }
}
