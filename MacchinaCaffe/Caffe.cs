using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacchinaCaffe
{
    public class Caffe
    {
        private string _id;
        private string _nome;
        private float _prezzo;
        private int _contzucchero;
        public string Id { get { return _id; } private set { _id = value; } }
        public int contZucchero {  get { return _contzucchero;} private set { _contzucchero = value; } }
        public string nome { get { return _nome; } private set { _nome = value; } }
        public float prezzo { get { return _prezzo; } private set { _prezzo = value; } }
        public Caffe(string nome, float prezzo, string id)
        {
            this.nome = nome;
            this.prezzo = prezzo;
            this._id = id;
        }
        public void aumentaZucchero()
        {
            contZucchero++;
        }
    }
}
