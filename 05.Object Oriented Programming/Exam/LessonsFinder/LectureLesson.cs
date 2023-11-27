using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LectureLesson : Lesson
{
    public LectureLesson(string title, int duration, int grade, int difficulty, string teacher, string location) 
        : base(title, duration, grade, difficulty, teacher)
    {
        this.Location = location;
    }

    public string Location { get; }

    public override string ToString()
        => 
            $"Title: {Title} for {Grade} grade ({Duration} mins.) - difficulty {Difficulty} by {Teacher} (Rating: {Rating} / 5) @ Onsite: {Location}"
            .ToString();

}