namespace Vacancies.Web.Endpoints
{
    public class ApplicantsEndpoint
    {
        public static string Get(int vacancyId) => $"https://localhost:7181/api/applicants/{vacancyId}";

        public static string Detail(int userId,int vacancyId) => $"https://localhost:7181/api/result/{userId}/{vacancyId}";


    }
}
