﻿namespace NSS.WebAPI.Models.Domain
{
    public class Contact
    {
        public int Id { get; set; } 
        public string Email  { get; set; }

        public int AddressId { get; set; }

        public string Phone { get; set; }
    }
}
