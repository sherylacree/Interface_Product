using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Product;
public interface IProduct {
    string ProductName { get; set; }
    decimal ProductPrice { get; set; }

    decimal ProductWeight { get; set; }


    
}
