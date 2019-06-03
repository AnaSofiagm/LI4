using LI4.DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace Cooklicous {

    public class DAOUtilizador {

        public void Teste(ref Utilizador user)
        {
            string connetionString = null;
            string sql = null;
            connetionString = "\"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog='D:\\UNIPROJECTS\\LI4 V2.0\\LI4\\COOKILICIOUS\\LI4\\APP_DATA\\DATABASE1.MDF';Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False\"";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                sql = @"insert into dbo.User (idUser, Username, Email, Password)
                               values(@id, @username, @email, @password);";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@id", user.GetId());
                    cmd.Parameters.AddWithValue("@username", user.GetNome());
                    cmd.Parameters.AddWithValue("@email", user.GetEmail());
                    cmd.Parameters.AddWithValue("@password", user.GetPassword());
                    cmd.ExecuteNonQuery();
                }
            }
        }

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
