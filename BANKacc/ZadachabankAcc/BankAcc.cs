using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadachabankAcc
{
    public class BankAcc
    {
        private string id;
        public string Id 
        {
            get { return id; }
            set{ id = value; }
        } 

        private string name;
        public string Name
        {
            get { return name; }    
            set { name = value; }
        }

        private string status;
        public string Status
        {
          get { return status; }
          set {  status = value; }
        }

        private decimal smetka;
        public decimal Smetka
        {
            get { return smetka; }
            set { smetka = value; }
        }
        public BankAcc(string id,string name, string status, decimal smetka)
        {
            this.name = name;
            this.id = id;
            this.status = status;
            this.smetka = smetka;
        }

        public void izhod()
        {
            Console.WriteLine($"{this.Name} e s ID-{this.Id}, {this.Status} status i {this.Smetka}lv. ");
        }
        public void Inserttp(decimal price)
        {
            smetka += price;
        }
        public void Removep(decimal rprice)
        {
            smetka -= rprice;
        }
    }
}
