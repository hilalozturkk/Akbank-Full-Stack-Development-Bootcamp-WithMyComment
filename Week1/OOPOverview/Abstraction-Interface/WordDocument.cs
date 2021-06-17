using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction_Interface
{
    public class WordDocument : Document , IPrintable
    {
        public override void Load()
        {
            throw new NotImplementedException();
        }

        public void Print() // 
        {
            throw new NotImplementedException();
        }

        //public override void Print()
        //{
        //    throw new NotImplementedException();
        //}

        public override void Save()     // only abstract method 
        {
            throw new NotImplementedException();
        }
    }
}
