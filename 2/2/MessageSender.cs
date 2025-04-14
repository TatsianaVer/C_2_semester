using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MessageSender
{
    public bool Execute(ChatData data, string username, string message)
    {
        if (string.IsNullOrEmpty(username) ||
            string.IsNullOrEmpty(message) ||
            !data.Users.Contains(username) ||
            data.BannedWords.Any(word => message.Contains(word)))
        {
            return false;
        }    

        data.Messages.Add($"{username}: {message}");

        return true;
    }
}
