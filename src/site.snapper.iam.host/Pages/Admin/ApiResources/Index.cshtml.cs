using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace site.snapper.iam.host.ApiResources
{
    [SecurityHeaders]
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly ApiResourceRepository _repository;

        public IndexModel(ApiResourceRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<ApiResourceSummaryModel> Scopes { get; private set; }
        public string Filter { get; set; }

        public async Task OnGetAsync(string filter)
        {
            Filter = filter;
            Scopes = await _repository.GetAllAsync(filter);
        }
    }
}