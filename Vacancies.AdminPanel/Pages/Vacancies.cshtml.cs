using Microsoft.AspNetCore.Mvc.RazorPages;
using Vacancies.AdminPanel.ViewModel;
using Vacancies.AdminPanel.ViewModel.Responses;
using Vacancies.Web.Endpoints;

namespace Vacancies.AdminPanel.Pages
{
    public class VacanciesModel : PageModel
    {
        private readonly ILogger<VacanciesModel> _logger;

        private readonly HttpClient _httpClient;
        private readonly IHttpClientFactory _httpClientFactory;

        public List<VacancyViewModel> _vacanciesViewModel = new List<VacancyViewModel>();
        public VacanciesModel(ILogger<VacanciesModel> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
            _httpClient = _httpClientFactory.CreateClient();
        }

        public async Task OnGetAsync()
        {
            try
            {
                _httpClient.DefaultRequestHeaders.Clear();
                _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                              _httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

                _httpClient.Timeout = TimeSpan.FromMinutes(5);
                System.Net.ServicePointManager.Expect100Continue = false;

                var response = await _httpClient.GetFromJsonAsync<ResponseResult<List<VacancyViewModel>>>(VacancyEndpoints.GetActiveVacansies);

                _logger.LogInformation($"Response with status {response?.StatusCode} and message {response?.ErrorMessage}");

                if (response != null && response?.Result != null)
                    _vacanciesViewModel = response?.Result;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error occured during calling of method {nameof(OnGetAsync)}.Details:{ex.Message}");
            }
        }
    }
}
