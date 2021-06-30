using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstracts
{
    public interface IMessageService
    {
        IDataResult<List<Message>> GetAll();
        IResult Send(Message message);

    }
}
