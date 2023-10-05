using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_itsystem;

public class NewsUploader : User
{
    public NewsUploader(string username, string email) : base(username, email)
    {
    }

    // Children kan använda UploadNews!
    public bool UploadNews(string title, string content)
    {
        if (content.Length > 0)
        {
            Console.WriteLine("Uploaded news: " + title);
            return true;
        }
        else
        {
            return false;
        }
    }
}
