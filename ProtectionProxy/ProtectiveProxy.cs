using ProtectionProxy.Constants;

namespace ProtectionProxy;

public class ProtectiveProxy(string name, string content) : Document(name, content)
{
    protected override void UpdateName(string newName, User user)
    {
        if (user.Role != Roles.Author)
        {
            throw new UnauthorizedAccessException("Cannot update name unless in Author role");
        }
        
        base.UpdateName(newName, user);
    }

    protected override void CompleteReview(User editor)
    {
        if (editor.Role != Roles.Editor)
        {
            throw new UnauthorizedAccessException("Cannot review documents unless you are an editor");
        }
        
        base.CompleteReview(editor);
    }
}