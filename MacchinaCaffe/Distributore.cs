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
        private int qcaffe;
        public float credito { get { return _credito; } private set { _credito = value; } }
        public string id { get { return _id; } private set { _id = value; } }
        public Caffe[] caffe { get { return _caffe; } private set { _caffe = value; } }
        
        public Distributore(string id, Caffe[] caffe)
        {
            credito = 0;
            this.id = id;
            this.caffe = caffe;
            occupato = false;
            qcaffe = 10;
        }   
        public void acquistaCaffe(Caffe selezione)
        {
            if(credito >= selezione.prezzo)
            {
                erogazione();
            }
        }
        public void erogazione()
        {
            if ((qcaffe - 1) >= 0)
            {
                qcaffe--;
                credito--;
            }
        }
        public void ricaricacaffe(int qricarica)
        {
            if(qricarica >= 0 && (qcaffe + qricarica)<=0 )
            qcaffe++;
        }
        public void ricaricacredito(int qcredito)
        {
            if(qcredito >= 0)
            credito = credito + qcredito;
        }
        /*public string visualizza()
        {
            string visualizza;
            for (int i = 0; i < caffe.Length; i++)
            {
                visualizza = 
            }
        }*/
    }
}
