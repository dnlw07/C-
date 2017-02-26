using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsAndEvents2
{
    class Program
    {
        public delegate void MyDelegate(bool newMode);

        static void Main(string[] args)
        {
            // tworzy nowego bloggera
            Blogger blogger = new Blogger();
            
            // tworzy nowych użytknowników
            User user1 = new User("Adam", blogger);
            User user2 = new User("Barbara", blogger);
            User user3 = new User("Cezary", blogger);

            // Tworzy argumenty opisujące dany podcast
            BloggerEventArgs bloggerArgs = new BloggerEventArgs("Odcinek 1", 100);
            // w evencie informuje o nowym poście
            blogger.OnNewVideoBlog(bloggerArgs);
            bloggerArgs = new BloggerEventArgs("Odcinek 2", 220);
            blogger.OnNewVideoBlog(bloggerArgs);

            Console.ReadKey();
        }
    }
}
