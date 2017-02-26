using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsAndEvents2
{
    class User
    {
        public string Name { get; private set; }
        public User(string name, Blogger blogger)
        {
            Name = name;
            // podpięce się pod event w celu subskrypcji
            blogger.NewVideoBlog += Blogger_NewVideoBlog;
        }

        // event
        private void Blogger_NewVideoBlog(object sender, EventArgs e)
        {
            if (e is  BloggerEventArgs)
            {
                BloggerEventArgs bloggerEventArgs = e as BloggerEventArgs;

                Console.WriteLine("Użytkowniku {0} Nowy film od Bloggera!", Name);
                Console.WriteLine("Tytył: {0}", bloggerEventArgs.Title);
                Console.WriteLine("Czas: {0}sek.", bloggerEventArgs.DurationInSeconds);
                Console.WriteLine();
            }
        }
    } 
}
