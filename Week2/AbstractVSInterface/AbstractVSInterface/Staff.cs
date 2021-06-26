using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractVSInterface
{
    public class Staff
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public IAdress Adress { get; set; }
    }

    public interface IAdress
    {
        public string City { get; set; }
        public string Country { get; set; }
        public string Street { get; set; }
        public string Neighborhood { get; set; }
    }

    public class HomeAdress : IAdress
    {

        public int postalCode { get; set; }
        public string City { get  ; set  ; }
        public string Country { get  ; set  ; }
        public string Street { get  ; set  ; }
        public string Neighborhood { get  ; set  ; }
    }
    public class WorkAdress : IAdress
    {

        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Street { get; set; }
        public string Neighborhood { get; set; }
    }
}
