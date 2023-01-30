using LMS.Models.ModelContracts;

namespace LMS.Models
{
    public class Customer:IEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }    
        public string Code { get; set; }
       
    }
}
