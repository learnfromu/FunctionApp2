using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionApp2
{
    public class ProductRating
    {
        
        public string ProductId { get; set; }
        public string UserId { get; set; }
        public string Id { get; set; }
        public DateTime Timestamp { get; set; }

        public void PopulateIdandTime()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Timestamp = DateTime.Now.ToUniversalTime();
        }
    }
}
