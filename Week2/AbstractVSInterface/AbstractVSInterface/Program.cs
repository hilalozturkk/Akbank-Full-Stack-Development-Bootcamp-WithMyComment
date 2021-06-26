using System;
using System.IO;

namespace AbstractVSInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //FileStream fileStream = new FileStream("", FileMode.Create);
            MemoryStream memoryStream = new MemoryStream();
            //Stream stream = fileStream;

            Staff staff = new Staff();
            //  staff.Adress = new Adress(); //need to get this instance -> inheritance
            staff.Adress = new HomeAdress(); // interface
            staff.Adress = new WorkAdress() { Longitude = 42, Latitude = 26 };
            if (staff.Adress is WorkAdress) //
            {
                
                Console.WriteLine("");
            }
  
            Console.WriteLine(staff.Adress.City);
        }
    }

    public abstract class MyStream
    {
        /* FileStream
         * MemoryStream
         * NetworkStream
         * 
         * common feature -> readStream writeStream 
         * not common -> copyStream
        */

        public abstract void Write(byte[] data); //byte array
        public abstract byte[] Read();
        public void Copy(string from, string to)
        {
            Console.WriteLine("Copying...");
        }
    }
    public class FileStream : MyStream
    {
        public override byte[] Read() 
        {
            throw new NotImplementedException();
        }

        public override void Write(byte[] data)
        {
            throw new NotImplementedException();
        }
    }
    public class MemoryStream : MyStream
    {
        public override byte[] Read()
        {
            throw new NotImplementedException();
        }

        public override void Write(byte[] data)
        {
            throw new NotImplementedException();
        }
    }

    
}