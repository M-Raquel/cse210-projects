public class Assignment
{
    //2 string attributes of name and topic.
    private string _studentName;
    private string _topic;

    //Constructor that recieves student name,topic and sets variables
    public Assignment(string studentname, string topic)
    {
        _studentName = studentname;
        _topic = topic;
    }

    //Put Getters so you can access the attributes outside the class as well.
    public string GetStudentName(){
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }
    //A method that gets a summary
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}