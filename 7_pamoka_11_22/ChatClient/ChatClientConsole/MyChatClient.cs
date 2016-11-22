using Chat;
using Chat.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClientConsole
{
     public class MyChatClient
    {
        private ChatClient klientas;
        
        public MyChatClient()
        {
            klientas = new ChatClient();
           
        }
        public bool login(string username, string password)
        {
            bool arPrisijungiau = true;
            try
            {
                klientas.Register(username, password);

            }
            catch
            {
                arPrisijungiau = false;
            }
         
            return arPrisijungiau;
        }
        public bool SendSmS(string name, string text)
        {
            bool arNusiunte = true;
            try
            {
                klientas.SendMessage(name, text);
            }
            catch
            {
                arNusiunte = false;
            }
            return arNusiunte;
        }
        public List<string> getusernames()
        {
            List<Message> zinutes = new List<Message>();
            List<string> usernames = new List<string>();
            try
            {
                
                zinutes = klientas.GetAllMessages();
            }
            catch
            {
                Console.WriteLine("Nepavyko");

            }
            foreach( var zinute in zinutes)
            {
                usernames.Add(zinute.From);
            }
            return usernames;
        }

    }

}
