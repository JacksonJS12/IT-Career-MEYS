using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class OnlineLesson : Lesson
{
    public OnlineLesson(string title, int duration, int grade, int difficulty, string teacher, string platform) 
        : base(title, duration, grade, difficulty, teacher)
    {
        if (title.Length < 3 || title.Length > 30)
        {
            throw new ArgumentException("Platform should be between 3 and 30 characters!");
        }

        this.Platform = platform;

    }
    public string Platform { get; }

    public override string ToString()
        =>
            $"Title: {Title} for {Grade} grade ({Duration} mins.) - difficulty {Difficulty} by {Teacher} (Rating: {Rating} / 5) @ Online: {Platform}"
                .ToString();
}