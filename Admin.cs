using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_itsystem;

public class Admin : NewsUploader
{
    public Admin(string username, string email) : base(username, email)
    {
    }
}
