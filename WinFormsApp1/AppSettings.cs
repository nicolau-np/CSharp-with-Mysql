using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public static class AppSettings
    {
        public static string connectionString()
        {
            string connectionString = "Server=localhost;Database=csharp;Uid=root;Pwd=''";
            return connectionString;
        }
    }
}
