using System;
using System.Collections.Generic;
using LI4.DataAccess;

namespace Cooklicous {

    public class DAOReceita {
		public int Insert(ref Receita rec) {
            int id = rec.GetId();
            string nome = rec.GetNome();
            int dificuldade = rec.GetDificuldade();
            int avaliacao = rec.GetAvaliacao();
            Categoria categoria = rec.GetCategoria();
            string infoNut = rec.GetInfo();
            int tempoPrep = rec.GetTempo();


            string sqlCode = @"insert into dbo.Receita (idReceita, NomeReceita, Dificuldade, Avaliacao, Categoria, InformacaoNutricional, TempoPreparacao)
                               values(@id, @nome, @dificuldade, @avaliacao, @categoria, @infoNut, @tempoPrep);";

            return DbAccess.SaveData(sqlCode, rec);
        }


        public void Update(ref Receita rec) {
			throw new System.Exception("Not implemented");
		}


        public void Delete(ref int id) {
			throw new System.Exception("Not implemented");
		}


        public List<Receita> Get(ref int id) {
            int getId = id;
            string sqlCode = @"select * from dbo.Receita
                               where idReceita = @getId;";

            return DbAccess.LoadData<Receita>(sqlCode);
        }


        public List<Receita> GetAllCategoria(ref int id) {
            int searchId = id;

            string sqlCode = @"select * from dbo.Receita
                               where idReceita = @searchId;";

            return DbAccess.LoadData<Receita>(sqlCode);


        }

        public List<Receita> GetByName(ref string name){
            string rec_name = name;
            string sqlCode = @"select * from dbo.Receita where idReceita LIKE %@rec_name%";

            return DbAccess.LoadData<Receita>(sqlCode);
        }


    }

}
