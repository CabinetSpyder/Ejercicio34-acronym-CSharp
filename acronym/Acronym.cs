using System.ComponentModel.DataAnnotations;
using System.Text;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {

        if(string.IsNullOrWhiteSpace(phrase))
        {
            return "";
        }

        var auxStr = new StringBuilder();
        bool pickNextLetter = false;
        
        auxStr.Append(phrase[0]);

        foreach(char ch in phrase)
        {
            
            if(pickNextLetter && char.IsLetter(ch))
            {
                auxStr.Append(ch);
                pickNextLetter = false;
            }

            if(char.IsWhiteSpace(ch) || ch == '-')
            {
                pickNextLetter = true;
            }
            
        }

        return auxStr.ToString().ToUpper();
    }
}