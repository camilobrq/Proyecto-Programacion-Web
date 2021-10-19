using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class CitaNoEncontradaException : Exception
    {
        public CitaNoEncontradaException()
        {
        }

        public CitaNoEncontradaException(string message) : base(message)
        {

        }
    }
}