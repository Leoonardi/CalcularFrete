using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularFrete.Controller
{
    internal class Frete
    {
        private decimal valor;
        private decimal frete;
        private string UF;

    public decimal calcular(string uf, decimal v)
    {

        this.UF = uf;
        this.valor = v;
        this.frete = 0;

        switch (uf)
        {
            case "SP":
                this.frete = 0.06m;
                break;

            case "RJ":
                this.frete = 0.07m;
                break;

            case "BA":
                this.frete = 0.08m;
                break;

            case "PE":
                this.frete = 0.08m;
                break;

            case "PA":
                this.frete = 0.08m;
                break;

            case "RS":
                this.frete = 0.08m;
                break;
        }

        valor = frete + valor;
        return valor;
    }

    }
}




