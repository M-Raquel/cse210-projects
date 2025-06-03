
public class MathAssignment : Assignment
{
    //2 strings of textbook section and problems
    private string _textbookSection;
    private string _problems;

    //Constructor from the Math class that takes in Assignement parameters
    public MathAssignment(string studentname, string topic, string textbookSection, string problems) : base(studentname, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    //Method to get the homework
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
    
}