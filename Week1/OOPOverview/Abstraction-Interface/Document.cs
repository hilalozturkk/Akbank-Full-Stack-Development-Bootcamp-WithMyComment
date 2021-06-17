using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction_Interface
{
    public abstract class Document
    {
        public void Copy(string from, string to) //
        {
            Console.WriteLine("Copying..");
        }

        public void ChangeName()
        {

        }
        public int Size { get; set; }

        //PDF, Excel, Word -> 

        public abstract void Save(); // must overrride

        public abstract void Load();

      //  public abstract void Print(); //anymore ability not must

        
            
    }
}
