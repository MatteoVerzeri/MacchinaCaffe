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
        public int contatore;
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
            contatore = 0;
        }
        public void Aggiungi(Caffe sel)
        {
            caffe[contatore] = sel;
            contatore++;
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
        
        public string Visualizza()
        {
            string visualizza = "";
            for (int i = 0; i < contatore; i++)
            {
                visualizza += caffe[i].ToString();
            }
            return visualizza;

        }
        public int ricercaid(Caffe c)
        {
            for (int i = 0; i < contatore - 1; i++)
            {
                if (c.Id == caffe[i].Id)
                {
                    return contatore;
                }
            }
            return -1;
        }
        public void Elimina(Caffe c)
        {
            int pos = ricercaid(c);
            if (pos != -1)
            {
                for (int i = pos; i < contatore - 1; i++)
                {

                    caffe[i] = caffe[i + 1];
                    
                }
            }
            else
            {
                throw new Exception("prodotto non trovato");
            }
        }
    }
}
