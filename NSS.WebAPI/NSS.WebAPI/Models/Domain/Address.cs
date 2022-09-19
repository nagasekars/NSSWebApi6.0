namespace NSS.WebAPI.Models.Domain
{
    public class Address
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int Pincode { get; set; }

        public string Country { get; set; }



    }
}
