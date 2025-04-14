using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 3. Удаление пользователя (1 класс = 1 метод)
public class UserRemover
{
    public void Execute(ChatData data, string username)
    {
        data.Users.Remove(username);
    }
}