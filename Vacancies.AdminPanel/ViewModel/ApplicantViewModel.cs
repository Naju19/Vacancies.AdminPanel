using Vacancies.AdminPanel.ViewModels;

namespace Vacancies.AdminPanel.ViewModel
{
    public class ApplicantViewModel
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public  UserViewModel User { get; set; }

        public int VacancyId { get; set; }
        public VacancyViewModel Vacancy { get; set; }

        //public int? CVFileId { get; set; }
        //public CVFile? CVFile { get; set; }

        public DateTime AppliedDate { get; set; }

        public List<AnswerViewModel> Answers { get; set; }
    }
}
