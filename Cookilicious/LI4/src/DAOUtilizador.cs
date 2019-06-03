using LI4.DataAccess;
using System;
using System.Collections.Generic;

namespace Cooklicous {

    public class DAOUtilizador {

        public int Insert(ref Utilizador user) {
            int id = user.GetId();
            string username = user.GetNome();
            string email = user.GetEmail();
            string password = user.GetPassword();
            
            string sqlCode = @"insert into dbo.User (idUser, username, email, password)
                               values(@id, @username, @email, @password);";

            return DbAccess.SaveData(sqlCode, user);
        }



        public void Update(ref Utilizador user) {
			throw new System.Exception("Not implemented");
		}



        public void Delete(ref int id) {
			throw new System.Exception("Not implemented");
		}



        public List<Utilizador> Get(ref int id) {
            int getId = id;
            string sqlCode = @"select * from dbo.User
                               where idUser = @getId;";

            return DbAccess.LoadData<Utilizador>(sqlCode);
		}


	}

}
