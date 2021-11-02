using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class PsicologoNoEncontradaException : Exception
    {
        public PsicologoNoEncontradaException()
        {
        }

        public PsicologoNoEncontradaException(string message) : base(message)
        {

        }
    }
}