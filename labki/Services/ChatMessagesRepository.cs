using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using labki.Entities;

namespace labki.Services
{
    public class ChatMessagesRepository : IChatMessagesRepository
    {
        public readonly List<ChatMessageEntity> _messages = new List<ChatMessageEntity>();
        public void AddMessage(ChatMessageEntity message)
        {
            _messages.Add(message);
        }

        public IEnumerable<ChatMessageEntity> GetAll()
        {
            return _messages;
        }
    }
}
