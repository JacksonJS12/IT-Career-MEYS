using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public abstract class Lesson
{
    protected List<int> ratings = new List<int>();
    protected Lesson(string title, int duration, int grade, int difficulty, string teacher)
    {
        if (title.Length < 3 || title.Length > 54)
        {
            throw new ArgumentException("Title should be between 3 and 54 characters!");
        }

        if (duration < 0)
        {
            throw new ArgumentException("Duration should be positive!");
        }

        if (grade < 1 || grade > 12)
        {
            throw new ArgumentException("Grade should be between 1 and 12!");
        }

        if (difficulty < 1 || difficulty > 3)
        {
            throw new ArgumentException("Difficulty should be between 1 and 3!");
        }

        if (teacher.Length < 3 || teacher.Length > 54)
        {
            throw new ArgumentException("Teacher should be between 3 and 54 characters!");
        }

        this.Title = title;
        this.Grade = grade;
        this.Difficulty = difficulty;
        this.Teacher = teacher;
        this.Duration = duration;
    }
    public string Title { get; }
    public int Duration { get; }
    public int Grade { get; }
    public int Difficulty { get; }
    public string Teacher { get; }

    public void AddRating(int rate)
        => this.ratings.Add(rate);


    public double Rating
    {
        get
        {
            return this.ratings.Average(r => r);
        }
    }

    public override string ToString()
    {
       StringBuilder sb = new StringBuilder();

       sb
           .AppendLine(
               $"Title: {Title} for {Grade} grade ({Duration} mins.) - difficulty {Difficulty} by {Teacher} (Rating: {Rating} / 5)");

       return sb.ToString();
    }
}
