using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class UserAdder
{
    public void Execute(ChatData data, string username)
    {
        if (!string.IsNullOrEmpty(username) && !data.Users.Contains(username))
            data.Users.Add(username);
    }
}
