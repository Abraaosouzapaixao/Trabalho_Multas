using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDTrabalho.Business
{
    class RidBusiness
    {
        Database.RidDatabase ridDB = new Database.RidDatabase();
        public void NovaSaida(Model.RidModel model)
            
        {
            if(model.Piloto == string.Empty)
            throw new ArgumentException("Piloto obrigratorio");

            if (model.Carro == string.Empty)
                throw new ArgumentException("carro obrigatorio");

            ridDB.NovaSaida(model);
        }
        public void MarcarChegada(int id,TimeSpan chegada,string obsevacao)
        {
            if (id == 0)
                throw new ArgumentException("id Obrigatorio");

            ridDB.MarcarChegada(id,  chegada ,obsevacao);

        }
        public void AtribuirMulta(int id,decimal valor,int pontos)
        {
            if (id == 0)
                throw new ArgumentException("id nao pode ser zero");
            if(valor == 0)
                throw new ArgumentException("valor nao pode ser zero");
            if (pontos == 0)
                throw new ArgumentException("pontos nao pode ser zero");
            ridDB.atribuirMulta(id, valor, pontos);

        }
        public List<Model.RidModel>fitrar(string piloto,DateTime dia)
        {
            List<Model.RidModel> lista = ridDB.Fitrar(piloto, dia);
            return lista;
        }
        public void RemoverSaida(int id)
        {
            if (id == 0)
                throw new ArgumentException("id nao pode ser zero");

            ridDB.RemoverSaida(id);

        }
        public Model.RidModel BuscarPorid(int id)
        {
            if (id == 0)
                throw new ArgumentException("id nao pode ser zero");
            Model.RidModel rid = ridDB.BuscarPorid(id);
            return rid;

            
        }
        

    }
}
