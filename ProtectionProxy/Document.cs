namespace ProtectionProxy;

public abstract class Document(string name, string content)
{
    private string _name = name;

    protected virtual void UpdateName(string newName, User user)
    {
        _name = newName;
    }

    protected virtual void CompleteReview(User editor)
    {
        
    }
}