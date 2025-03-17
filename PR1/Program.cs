using System;

public class Student
{
    public string Name { get; set; }
    public int Course { get; set; }
    public bool IsMale { get; set; }

  
    public Student(string name, int course, bool isMale)
    {
        Name = name;
        Course = course;
        IsMale = isMale;
    }

 
    public void DisplayInfo()
    {
        string gender = IsMale ? "Мужской" : "Женский";
        Console.WriteLine($"Имя: {Name}, Курс: {Course}, Пол: {gender}");
    }
}