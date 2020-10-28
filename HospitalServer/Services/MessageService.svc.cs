using System;
using System.Collections.Generic;
using System.Linq;
using HospitalEntities.Models;
using HospitalServer.Dto;
using HospitalServer.Repositories;

namespace HospitalServer.Services
{
    public class MessageService : IMessageService
    {
        private readonly Repository<Message> _messageRepository;

        public MessageService()
        {
            _messageRepository = new Repository<Message>(new ApplicationDatabaseContext());
        }

        /*
         * Get the last messages
         */
        public IEnumerable<Message> GetLastMessages()
        {
            return _messageRepository.GetAll()
                                     .OrderByDescending(m => m.CreatedAt)
                                     .Take(5);
        }

        public ResponseErrorEnum? AddMessage(string description)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(description))
                {
                    return ResponseErrorEnum.EmptyInput;
                }

                var message = new Message
                {
                    CreatedAt = DateTime.Now,
                    Description = description
                };

                _messageRepository.Insert(message);
                _messageRepository.Save();
            }
            catch
            {
                // TODO: Log the exception.
                return ResponseErrorEnum.RepositoryError;
            }

            return null;
        }

        public IEnumerable<Message> GetMessages()
        {
            return _messageRepository.GetAll();
        }
    }
}
