using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDTrabalho.Database
{
    class test
    {
        public void NovaSaida(Model.RidModel model)
        {
            string script = @"insert into tb_rid (nm_piloto, nm_carro, dt_dia, hr_saida, bt_multa)
                                          values (@nm_piloto, @nm_carro, @dt_dia, @hr_saida, @bt_multa)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_piloto", model.Piloto));
            parms.Add(new MySqlParameter("nm_carro", model.Carro));
            parms.Add(new MySqlParameter("dt_dia", model.Dia));
            parms.Add(new MySqlParameter("hr_saida", model.Saida));
            parms.Add(new MySqlParameter("bt_multa", model.TeveMulta));

            DB dB = new DB();
            dB.ExecuteInsertScript(script,parms);
        }
        
    }
}
