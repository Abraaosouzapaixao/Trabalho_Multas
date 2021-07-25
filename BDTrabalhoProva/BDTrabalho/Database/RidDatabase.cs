using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace BDTrabalho.Database
{
    class RidDatabase
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

            DB db = new DB();
            db.ExecuteInsertScript(script, parms);
        }

        public void MarcarChegada(int id, TimeSpan chegada, string obsevacao )
        {
            string script = @"update  tb_rid set hr_chegada = @hr_chegada,
                                              ds_observacao = @ds_observacao
                                               where id_rid = @id_rid    ";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("hr_chegada", chegada));
            parms.Add(new MySqlParameter("id_rid", id));
            parms.Add(new MySqlParameter("ds_observacao", obsevacao));

            DB db = new DB();
            db.ExecuteInsertScript(script, parms);
        }
        public void atribuirMulta(int id ,decimal valor , int pontos)
        {
            string script = @"update tb_rid set vl_multa = @vl_multa,
                                                 qt_pontos = @qt_pontos,
                                                  bt_multa = @bt_multa 
                                          where id_rid = @id_rid ";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("vl_multa", valor));
            parms.Add(new MySqlParameter("qt_pontos", valor));
            parms.Add(new MySqlParameter("bt_multa", valor));
            parms.Add(new MySqlParameter("id_rid", valor));


            DB db = new DB();
            db.ExecuteInsertScript(script, parms);
        }
        public void RemoverSaida(int id)
        {
            string script = @"delete from tb_rid where id_rid = @id_rid";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_rid",id));

            DB db = new DB();
            db.ExecuteInsertScript(script, parms);
        }
        public Model.RidModel BuscarPorid(int id)
        {
            string script = "select * from tb_rid where id_rid = @id_rid";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_rid", id));

            DB db = new DB();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            

            Model.RidModel model = null;

            if (reader.Read())
            {
                model = new Model.RidModel();
                model.Id = Convert.ToInt32(reader["id_rid"]);
                model.Piloto = Convert.ToString(reader["nm_piloto"]);
                model.Carro = Convert.ToString(reader["nm_carro"]);
                model.Observacao = Convert.ToString(reader["ds_observacao"]);
                model.Dia = Convert.ToDateTime(reader["dt_dia"]);
                model.Saida = TimeSpan.Parse(reader["hr_saida"].ToString());
                model.Chegada = TimeSpan.Parse(reader["hr_chegada"].ToString());
                model.TeveMulta = Convert.ToBoolean(reader["bt_multa"]);
                model.MultaPreco = Convert.ToDecimal(reader["vl_multa"]);
                model.MultaPontos = Convert.ToInt32(reader["qt_pontos"]);
            }
            reader.Close();
            return model;
        }

        public List<Model.RidModel> Fitrar(string piloto, DateTime dia)
        {
            string script = "select * from tb_rid where nm_piloto like @nm_piloto and dt_dia = @dt_dia";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_piloto", "%" + piloto + "%"));
            parms.Add(new MySqlParameter("dt_dia", dia));


            DB db = new DB();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<Model.RidModel> lista = new List<Model.RidModel>();

            while (reader.Read())
            {
                Model.RidModel model = new Model.RidModel();
                model.Id = Convert.ToInt32(reader["id_rid"]);
                model.Piloto = Convert.ToString(reader["nm_piloto"]);
                model.Carro = Convert.ToString(reader["nm_carro"]);
                model.Observacao = Convert.ToString(reader["ds_observacao"]);
                model.Dia = Convert.ToDateTime(reader["dt_dia"]);
                model.Saida = TimeSpan.Parse(reader["hr_saida"].ToString());
                model.Chegada = TimeSpan.Parse(reader["hr_chegada"].ToString());
                model.TeveMulta = Convert.ToBoolean(reader["bt_multa"]);
                model.MultaPreco = Convert.ToDecimal(reader["vl_multa"]);
                model.MultaPontos = Convert.ToInt32(reader["qt_pontos"]);

                lista.Add(model);
            }
            reader.Close();

            return lista;
        }
    }
}
