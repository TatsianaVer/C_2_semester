using System;
using System.Collections.Generic;
using System.Linq;

// Класс данных (хранит состояние чата)
public class ChatData
{
    public List<string> Messages { get; } = new List<string>();
    public List<string> Users { get; } = new List<string>();
    public List<string> BannedWords { get; } = new List<string>();
    public string Name { get; }

    public ChatData(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Chat name cannot be empty.");
        Name = name;
    }
}
