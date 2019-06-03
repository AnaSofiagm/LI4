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
            
            string sqlCode = @"insert into dbo.User (idUser, Username, Email, Password)
                               values(@id, @username, @email, @password);";

            int ret = DbAccess.SaveData(sqlCode, user);

            if (ret == 1){

                string ut_sql_code = @"insert into dbo.User_has_Utensilios (FK_idUser_UserUtensilios, FK_idUtensilio_UserUtensilios)
                                     values(@id, @ut_id);";

                foreach (Utensilio ut in user.GetPref_utensilios()){
                    int ut_id = ut.GetId();

                    DbAccess.SaveData(ut_sql_code, user);
                }

                string it_sql_code = @"insert into dbo.User_has_Ingredientes (FK_idUser_UserIngrediente, FK_idIngrediente_UserIngrediente)
                                     values(@id, @it_id);";
                foreach (Ingrediente it in user.GetPref_ingredientes()){
                    int it_id = it.GetId();

                    DbAccess.SaveData(it_sql_code, user);
                }

                string cat_sql_code = @"insert into dbo.User_has_Ingredientes (FK_idUser_UserCategoria, FK_idCategoria_UserCategoria)
                                     values(@id, @cat_id);";
                foreach (Categoria cat in user.GetPref_categorias()){
                    int cat_id = cat.GetId();

                    DbAccess.SaveData(cat_sql_code, user);
                }
            }
            return ret;
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
