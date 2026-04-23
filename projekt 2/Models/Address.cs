using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomReservationApp
{
    public class Address
    {
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Street { get; set; }
        public int BuildingNumber { get; set; }
        public override string ToString()
        {
            return $"{PostCode} {City}, ul. {Street} {BuildingNumber}";
        }
        public Address() { }
        public Address(string city, string postCode, string street, int buildingNumber)
        {
            City = city;
            PostCode = postCode;
            Street = street;
            BuildingNumber = buildingNumber;
        }
    }
}
