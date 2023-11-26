using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;


public class Controller
{
    private readonly Dictionary<string, Subject> subjects;

    public Controller()
    {
        subjects = new Dictionary<string, Subject>();
    }

    public string AddSubject(List<string> args)
    {
        Subject subject = new Subject(args[0]);
        this.subjects[args[0]] = subject;

        return $"Created Subject {args[0]}!";
    }

    public string AddLesson(List<string> args)
    {
        string name = args[0];
        string title = args[1];
        int duration = int.Parse(args[2]);
        int grade = int.Parse(args[3]);
        int difficulty = int.Parse(args[4]);
        string teacher = args[5];
        string type = args[6];
        string lastParam = args[7];

        Lesson lesson;
        if (type == "online")
        {
            lesson = new OnlineLesson(title, duration, grade, difficulty, teacher, lastParam);
            subjects[name].AddLesson(lesson);
        }
        else if (type == "lecture")
        {
            lesson = new LectureLesson(title, duration, grade, difficulty, teacher, lastParam);
            subjects[name].AddLesson(lesson);
        }

        return $"Created Lesson {title} in Subject {name}!";
    }

    public string RateLesson(List<string> args)
    {
        string subjectName = args[0];
        string lessonTitle = args[1];
        int rate = int.Parse(args[2]);

        foreach (var subject in this.subjects)
        {
            if (subject.Key == subjectName)
            {
                subject.Value.AddRate(lessonTitle, rate);

                return $"Rated {lessonTitle} with {rate} rate";
            }
        }

        return $"Operation failed";
    }

    public string GetAverageRating(List<string> args)
    {
        string name = args[0];

        foreach (var subject in this.subjects)
        {
            if (name == subject.Key)
            {
                double averageRating = subject.Value.AverageRating();

                return $"The average rating is: {averageRating:F2}";
            }
        }

        return $"Operation failed";
    }

    public string GetLessonsByTeacher(List<string> args)
    {//TODO: Implement me...
        throw new NotImplementedException();
    }

    public string GetLessonsBetweenDuration(List<string> args)
    {
        string name = args[0];
        int from = int.Parse(args[1]);
        int to = int.Parse(args[2]);

        foreach (var subject in this.subjects)
        {
            if (name == subject.Key)
            {
                subject.Value.GetLessonsBetweenDuration(from, to);

            }
        }
        return $"Operation failed";
    }

}