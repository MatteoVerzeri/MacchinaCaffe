using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacchinaCaffe
{
    public class Distributore
    {
        private float _credito;
        private string _id;
        private Caffe[] _caffe;
        private bool occupato;
        public float credito { get { return _credito; } private set { _credito = value; } }
        public string id { get { return _id; } private set { _id = value; } }
        public Caffe[] caffe { get { return _caffe; } private set { _caffe = value; } }
        
        public Distributore(string id, Caffe[] caffe)
        {
            credito = 0;
            this.id = id;
            this.caffe = caffe;
            occupato = false;
        }   
        public void acquistaCaffe(int selezione)
        {
            
        }

    }
}
