using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoolandia.Genus
{
    class Equus : Animal
    {
        private string _genus = "Equus";
        private int _legs = 4;
        private bool _isHybrid;
        private bool _isFertile = true;
        public bool isHybrid
        {
            get { return _isHybrid; }
            set { _isHybrid = value; }
        }
        public string genus
        {
            get { return _genus; }
        }
        public int legs
        {
            get { return _legs; }
        }
        public bool isFertile
        {
            get { return _isFertile; }
            set { _isFertile = value; }
        }
    }
}
