using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch
{
    public class CustomException : Exception
    {
        private string _message;
        private readonly int _status;
        public CustomException() { }
        public CustomException(int status, string message) : base(message) 
        {
            _message = message;
            _status = status;
        }        
        public void ImprimirMensajeError()
        {
            switch (_status)
            {
                case 0:
                    _message = _message + "Caso 0";
                    break;
                case 1:
                    _message = _message + "Caso 1";
                    break;
                default:
                    break;
            }
            Console.WriteLine(_message);
        }
    }
}
