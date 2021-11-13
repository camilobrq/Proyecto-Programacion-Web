using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class AgendaNoEncontradaException : Exception
    {
        public AgendaNoEncontradaException()
        {
        }

        public AgendaNoEncontradaException(string message) : base(message)
        {

        }
    }
}