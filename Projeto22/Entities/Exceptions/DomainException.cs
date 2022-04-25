using System;

namespace Proj22.Entities.Exceptions{
    class DomainException : ApplicationException{
        public DomainException(string message)
            : base(message){

        }
    }
}