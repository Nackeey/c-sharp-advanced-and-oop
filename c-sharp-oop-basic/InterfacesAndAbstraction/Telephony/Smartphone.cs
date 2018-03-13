using System.Linq;

public class Smartphone : IBrowsable, ICallable
{
    public string BrowseTheNet(string url)
    {
        if (url.Any(ch => char.IsDigit(ch)))
        {
            return "Invalid URL!";
        }
        return $"Browsing: {url}!";
    }

    public string MakeCall(string phoneNumber)
    {
        if (phoneNumber.Any(d => !char.IsDigit(d)))
        {
            return "Invalid number!";
        }
        return $"Calling... {phoneNumber}";
    }

    
}

