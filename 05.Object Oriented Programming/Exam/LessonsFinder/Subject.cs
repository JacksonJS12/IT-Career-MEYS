using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Subject
{
    private List<Lesson> lessons = new List<Lesson>();
    public Subject(string name)
    {
        if (name.Length < 2 || name.Length > 40)
        {
            throw new ArgumentException("Name should be between 2 and 40 characters!");
        }

        this.Name = name;
    }
    public string Name { get; }

    public void AddLesson(Lesson lesson)
        => this.lessons.Add(lesson);

    public double AverageRating()
        => this.lessons.Average(l => l.Rating);

    public List<Lesson> GetLessonsByTeacher(string teacher)
        => this.lessons.Where(l => l.Teacher == teacher).OrderByDescending(l => l.Duration).ToList();

    public List<Lesson> GetLessonsBetweenDuration(int from, int to)
        => this.lessons.Where(l => l.Duration >= from && l.Duration <= to).OrderByDescending(l => l.Rating).ToList();

    public void AddRate(string title, int rate)
    {
        Lesson lesson = this.lessons.FirstOrDefault(l => l.Title == title);
        if (lesson == null)
        {
            throw new ArgumentException("Lesson not found!");
        }

        for (int i = 0; i < this.lessons.Count; i++)
        {
            if (this.lessons[i].Title == title)
            {
                this.lessons[i].AddRating(rate);
            }
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb
            .AppendLine($"Subject {Name}")
            .AppendLine($"Total Lessons: {lessons.Count}");

        return sb.ToString();
    }
}