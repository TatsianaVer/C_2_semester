using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 4. Добавление запрещенных слов (1 класс = 1 метод)
public class BannedWordAdder
{
    public void Execute(ChatData data, string word)
    {
        if (!string.IsNullOrEmpty(word) && !data.BannedWords.Contains(word))
            data.BannedWords.Add(word);
    }
}