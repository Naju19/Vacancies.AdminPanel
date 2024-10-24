namespace Vacancies.AdminPanel.ViewModel
{
    public class ApplicantResultViewModel
    {
        public int QuesionCount { get; set; }

        public List<AnswerDetailViewModel> Answers { get; set; }

        public int Score { get; set; }

        public decimal Percentage { get; set; }

        public string Color { get; set; }
    }

    
}
