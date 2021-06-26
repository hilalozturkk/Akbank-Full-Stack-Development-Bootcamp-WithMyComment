using System;

namespace LiskovSubstitutionPrinciple
{
    //It is necessary that two classes inheriting from a class can be used instead of each other
    //and the superclass object **without exception**
    class Program
    {
        static void Main(string[] args)
        {

            DataWriter dataWriter = new DataWriter();
            //dataWriter.Write("test",new XMLDataSource());
            dataWriter.Write("test", new DBDataSource());
            dataWriter.Write("test", new ExcelDataSource());
        }
        
        public abstract class DataSource
        {
            //public abstract void Write(string data);
            public abstract string Read(string data);
        }

        public interface IDataWritable
        {
            void Write(string data);

        }
        public class XMLDataSource : DataSource
        {
            public override string Read(string data)
            {
                Console.WriteLine("Data read from XML");
                return string.Empty;
            }

            //public override void Write(string data)
            //{
            //    Console.WriteLine("Data written to XML");
            //}
        }

        public class DBDataSource : DataSource, IDataWritable
        {
            public override string Read(string data)
            {
                Console.WriteLine("Data read from DB");
                return string.Empty;
            }

            public void Write(string data)
            {
                Console.WriteLine("Data written from DB");
            }
        }

        public class ExcelDataSource : DataSource, IDataWritable
        {
            public override string Read(string data)
            {
                throw new NotImplementedException();
            }

            public void Write(string data)
            {
                Console.WriteLine("Data written from Excel");
            }
        }
        public class DataWriter
        {
            public void Write(string data, IDataWritable dataSource)
            {
                //if (dataSource is XMLDataSource)
                //{
                //    throw new Exception("Data can't be written to XML.");
                //}

                dataSource.Write(data);

            }
        }
    }
}
