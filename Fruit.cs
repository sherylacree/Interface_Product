using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Product;
internal class Fruit : IProduct {

public string ProductName { get; set; } = string.Empty;
public decimal ProductWeight { get; set; } = .99m;
public decimal ProductPrice { get; set; } = .99m;

}

