using System.ComponentModel.DataAnnotations;

namespace ListaDeTarefasWebMVC.Models
{
    public class Task
    {
        public int Id { get; set; }
        [MaxLength(25)]
        public string? Title { get; set; }
        [MaxLength (60)]
        public string? Description { get; set; }
        public bool IsCompleted { get; set; } = false;

        public void CompleteTask()
        {
            IsCompleted = true;
        }


    }
}
