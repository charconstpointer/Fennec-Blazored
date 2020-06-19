namespace Fennec.Client.Models
{
    public class CreateNewAdvertisementRequest
    {
        public string Name { get; set; }
        public float PricePerView { get; set; }
        public string Path { get; set; }
    }   
}