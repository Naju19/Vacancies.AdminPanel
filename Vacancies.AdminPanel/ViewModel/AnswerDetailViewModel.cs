namespace Vacancies.AdminPanel.ViewModel
{
    public class AnswerDetailViewModel
    {
        public string QuestionText { get; set; }
        public bool IsCorrect { get; set; }
        public string AnsweredOption { get; set; }
        public int Seconds { get; set; }
    }
}
