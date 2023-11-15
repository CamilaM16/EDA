using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace service.Models
{
    public class EcommersDataBaseSettings
    {
        public string ConnectionString { get; set; } = null!;

        public string DatabaseName { get; set; } = null!;

        public string UserCollectionName { get; set; } = null!;
        
        public string ProductCollectionName { get; set; } = null!;
        
        public string InvoiceCollectionName { get; set; } = null!;
        
        public string CategoriesCollectionName { get; set; } = null!;
    }
}