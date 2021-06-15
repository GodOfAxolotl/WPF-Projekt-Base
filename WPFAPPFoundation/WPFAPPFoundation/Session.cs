using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFAPPFoundation
{
    public class Session : BaseNotificationClass
    {
        private int _x;
        public int x
        {
            get { return _x; }
            set { _x = value; }
        }

        public Session()
        {

        }

        public void loop()
        {

        }

        private void update()
        {
            OnPropertyChanged(nameof(x));
        }
    }
}
