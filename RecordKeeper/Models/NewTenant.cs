using RecordKeeper.Models.Interfaces;

namespace RecordKeeper.Models
{
    public class NewTenant : INewTenant
    {
        public int Room { get; set; }
        public double Rent { get; set; }
    }
}
