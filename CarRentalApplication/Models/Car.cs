namespace CarRentalApplication.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal PricePerDay { get; set; }
        public Car(int id,string name,decimal pricePerDay)
        {
            Id = id;
            Name = name;
            PricePerDay = pricePerDay;
        }
    }
}
