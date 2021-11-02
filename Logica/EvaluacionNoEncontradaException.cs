 using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class EvaluacionNoEncontradaException : Exception
    {
        public EvaluacionNoEncontradaException()
        {
        }

        public EvaluacionNoEncontradaException(string message) : base(message)
        {

        }
    }
}