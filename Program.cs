using System;

namespace Bot.Intagram.Profile
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite o nome do perfil:");
            String user = Console.ReadLine();
            Profile profile = Instagram.GetProfileByuser(user);

            Console.WriteLine(profile);


            Console.ReadKey();
        }
    }
}
