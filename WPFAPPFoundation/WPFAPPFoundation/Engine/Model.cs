using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFAPPFoundation.Engine
{
    class Model
    {

        //Modelsample 

        private int _x;
        public int x
        {
            get { return _x; }
            set { _x = value; }
        }

        public Model(int x)
        {
            this.x = x;
        }

        public void update()
        {
            //TODO: Add needed update to this Method
        }
    }
}
