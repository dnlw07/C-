using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsAndEvents2
{
    class Blogger
    {
        // deklaracja zdarzenia
        // EventHandler pomaga obiektom obsłużyć zdarzenie
        public event EventHandler NewVideoBlog;
        public void OnNewVideoBlog(BloggerEventArgs e)
        {
            EventHandler newVideoBlog = NewVideoBlog;
            // sprawdza czy ktoś nasłuchuje
            if (newVideoBlog != null)
                newVideoBlog(this, e); // ja bloger wywołuję to zdarzenie, jako obiekt który to przesyła
        }
    }

    class BloggerEventArgs : EventArgs
    {
        // Tytył
        public string Title { get; private set; }
        // Czas trwania Video Bloga
        public int DurationInSeconds { get; private set; }

        public BloggerEventArgs(string title, int durationInSecodns)
        {
            Title = title;
            DurationInSeconds = durationInSecodns;
        }
    }
}
