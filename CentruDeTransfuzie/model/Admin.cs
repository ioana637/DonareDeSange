using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentruDeTransfuzie.model
{
    public class Admin
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Parola { get; set; }

        public Admin()
        {
        }

        public Admin(string username, string parola)
        {
            Username = username;
            Parola = parola;
        }

        public Admin(int id, string username, string parola)
        {
            Id = id;
            Username = username;
            Parola = parola;
        }
    }
}
