using LMS.Models.ModelContracts;

namespace LMSApi.Models
{
    public class Customer:IEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }    
        public string Code { get; set; }
       
    }
}
