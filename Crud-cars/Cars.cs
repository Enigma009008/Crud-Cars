using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_cars
{
    public partial class Cars
    {
        public int ID { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }
        public string Color { get; set; }

        public Cars(string Model , int Speed , string Color )
        {
            this.Model = Model;
            this.Speed = Speed;
            this.Color = Color;
            
        }

        public Cars()
        {

        }

        
    }
}
