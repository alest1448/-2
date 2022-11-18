using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите логин и пароль");
            User user = new User()
            {
                Surname = "Иванов",
                Name = "Иван",
                Login = "admin",
                Password = "admin"
            };
            
            string login = Console.ReadLine();
            string password = Console.ReadLine();

            user.autorize(login, password);




            Console.WriteLine(user.Name);
            Console.WriteLine($"Введите имя");

            user.Name = Console.ReadLine();
            Console.WriteLine($"Ваше новое имя - {user.Name}");
           
      
        }

    }


    class User
    {
        public string Surname;
    public string Name;
    public string Login;
    public string Password;
        public void autorize(string login, string password)
        {
            if(login == Login && password == Password)
            {
                Console.WriteLine("Вы успешно авторизировались");

            }
            else
            {
                Console.WriteLine("Авторизация не удалась");

            }
        }
    }
}
