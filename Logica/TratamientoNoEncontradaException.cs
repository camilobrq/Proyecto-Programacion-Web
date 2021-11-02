 using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class TratamientoNoEncontradaException : Exception
    {
        public TratamientoNoEncontradaException()
        {
        }

        public TratamientoNoEncontradaException(string message) : base(message)
        {

        }
    }
}