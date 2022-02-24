using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using labki.Entities;

namespace labki.Services
{
    public interface IChatMessagesRepository
    {
        void AddMessage(ChatMessageEntity message);

        IEnumerable<ChatMessageEntity> GetAll();
    }
}
