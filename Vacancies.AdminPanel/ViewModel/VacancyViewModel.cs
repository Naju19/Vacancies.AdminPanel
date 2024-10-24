using System.ComponentModel.DataAnnotations;

namespace Vacancies.AdminPanel.ViewModel
{
    public class VacancyViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Header { get; set; }

        public string Description { get; set; }

        public int CategoryId { get; set; }

        public DateTime PublishedDate { get; set; }

        public int QuestionCount { get; set; }
    }
}
