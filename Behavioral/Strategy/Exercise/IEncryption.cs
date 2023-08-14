using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy.Exercise
{
    public interface IEncryption
    {
        void Encrypt(string message);
    }
}
