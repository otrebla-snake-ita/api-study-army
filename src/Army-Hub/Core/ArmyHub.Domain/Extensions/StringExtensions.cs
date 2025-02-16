using System.Text;

namespace ArmyHub.Domain.Extensions;

// TODO: Move in separate "common" assembly?
public static class StringExtensions
{
    public static string SplitCapitalLetters(this string str)
    {
        if (string.IsNullOrEmpty(str))
            return str;

        var sb = new StringBuilder();
        foreach (var c in str)
        {
            if (char.IsUpper(c) && sb.Length > 0)
                sb.Append(' ');

            sb.Append(c);
        }
        return sb.ToString();
    }
}
