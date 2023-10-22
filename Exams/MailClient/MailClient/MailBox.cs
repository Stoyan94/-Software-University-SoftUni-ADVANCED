using System.Text;

namespace MailClient
{
    public class MailBox
    {  
        public MailBox(int capacity)
        {
            this.Capacity = capacity;
            this.Inbox = new List<Mail>();
            this.Archive = new List<Mail>();
        }

        public int Capacity { get; set; }

        public List<Mail> Inbox {get; private set;}

        public List<Mail> Archive { get; private set; }

        public void IncomingMail(Mail addMessage)
        {
            if (Capacity > 0)
            {
                Capacity--;
                Inbox.Add(addMessage);
            }
            
        }

        public bool DeleteMail(string senderName)
        {
           var deletedMs =  this.Inbox.FirstOrDefault(x => x.Sender == senderName);

            if (deletedMs == null)
            {
                return false;
            }           
            Inbox.Remove(deletedMs);
            Capacity++;
            return true;

        }

        public int ArchiveInboxMessages()
        {
            int countMess = Inbox.Count;
            Capacity += countMess;

            var moveMessages = Inbox.ToList();

            Inbox.Clear();

            Archive = moveMessages;

            return countMess;
        }

        public Mail GetLongestMessage()
        {
            Mail longest = Inbox.MaxBy(x=>x.Body);
            
            return longest;
        }

        public string InboxView()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Inbox:");

            foreach (var drink in Inbox)
            {
                sb.AppendLine(drink.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
