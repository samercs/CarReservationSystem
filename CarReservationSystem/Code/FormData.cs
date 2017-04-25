using System;

namespace CarReservationSystem.Code
{
    public class FormData
    {
        public Customer Customer { get; set; }
        public int BookCarId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Bank { get; set; }
        public string CardNumber { get; set; }
        public DateTime Expire { get; set; }
        public string Pin { get; set; }
    }
}