public class WritingAssignment : Assignment
{
    //Attribute of title
    private string _title;
    //Constructor that takes in assignment parent
    public WritingAssignment(string studentname, string topic, string title) : base(studentname, topic)
    {
        _title = title;
    }
    //Method that returns writing information
    public string GetWritingInformation()
    {
        return _title + " by " + GetStudentName();
    }
}