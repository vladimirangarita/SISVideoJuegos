using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public struct Product
{
    public string Code;
    public string Name;

    public Product(string code, string name)
    {
        this.Code = code;
        this.Name = name;
    }

    public override string ToString()
    {
        return this.Code + "“t" + this.Name;
    }

}
