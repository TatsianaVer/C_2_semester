using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 5. Получение информации (1 класс = 1 метод)
public class ChatInfoGetter
{
    public string Execute(ChatData data)
    {
        return $"Chat: {data.Name}, Users: {data.Users.Count}, " +
               $"Messages: {data.Messages.Count}, Users: {string.Join(", ", data.Users)}";
    }
}