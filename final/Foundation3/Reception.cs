public class Reception : Event 
{   
    private string _email;
    private string _confirmationDueDate;

    public Reception(string title, string description, string date, string time, Address address, string email, string confirmationDueDate) : base(title, description, date, time, address)
    {
        _email = email;
        _confirmationDueDate = confirmationDueDate;
    }

    public string GetRSPVInformation()
    {
        return $" RSPV Information: \n Email: {_email} \n Confirmation Due Date: {_confirmationDueDate}";
    }
}