public class PlacedStudent
{
    private string _companyName;
    private string _studentName;

    public PlacedStudent(string companyName, string studentName)
    {
        _companyName = companyName;
        _studentName = studentName;
    }

    public string CompanyName
    {
        get { return _companyName; }
        set { _companyName = value; }
    }

    public string StudentName
    {
        get { return _studentName; }
        set { _studentName = value; }
    }
}
