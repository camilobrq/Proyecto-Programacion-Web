using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class PacienteNoEncontradaException : Exception
    {
        public PacienteNoEncontradaException()
        {
        }

        public PacienteNoEncontradaException(string message) : base(message)
        {

        }
    }
}