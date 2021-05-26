using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatoTelecom
{
    class Plano
    {
        private string _id;
        private string _nome;
        private string _franquia;
        private string _caracteristicas;
        private string _mensalidade;
        private string _ci;
        public string Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Franquia { get => _franquia; set => _franquia = value; }
        public string Caracteristicas { get => _caracteristicas; set => _caracteristicas = value; }
        public string Mensalidade { get => _mensalidade; set => _mensalidade = value; }
        public string Ci { get => _ci; set => _ci = value; }

        public Plano(string nome, string franquia, string caracteristica, string ci, string mensalidade)
        {
            Nome = nome;
            Franquia = franquia;
            Caracteristicas = caracteristica;
            Ci = ci;
            Mensalidade = mensalidade;
        }

    }
}
