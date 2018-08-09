namespace electron_poc.Models
{
    public class AddressModel
    {
        public string AddressLine1 { get; set; }
        public string City {get; set; }
        public string State {get; set; }
        public string Zip {get; set;}
        public string Phone {get; set;}

        public AddressModel(string addressLine1, string city, string state, string zip, string phone){
            AddressLine1 = addressLine1;
            City = city;
            State = state;
            Zip = zip;
            Phone = phone;
        }
    }
}