using System;
namespace Cooklicous {
	public class Cooklicious {
		private int passo;
		private Utilizador user;
		private Receita rec;
		private Planeador plan;
        private DAOIngrediente dao_ingrediente;
        private DAOPasso dao_passo;
        private DAOUtensilio dao_utensilio;
        private DAOReceita dao_receita;
        private DAOUtilizador dao_utilizador;
        private DAOPlaneador dao_planeador;
        private DAOCategoria dao_categoria;

        public void RegistarUtilizador(ref string nomeUser, ref string password, ref string email) {
            Utilizador _user = new Utilizador(nomeUser, email, password);

            dao_utilizador.Insert(ref _user);
		}

		public Receita[] ConsultarReceitasCategoria(ref int categoria) {
			throw new System.Exception("Not implemented");
		}

		public Receita[] ConsultarReceitasUtilizador(ref int idUser) {
            Utilizador _user = dao_utilizador.Get(ref idUser);

            return _user.GetReceitas();
		}

		public Ingrediente[] ConsultarIngredientesReceita(ref int idReceita) {
            Receita _rec = dao_receita.Get(ref idReceita);

            return _rec.GetIngredientes();
		}

		public Utensilio[] ConsultarUtensiliosReceita(ref int idReceita) {
            Receita _rec = dao_receita.Get(ref idReceita);

            return _rec.GetUtensilios();
        }

		public Passo[] ConsultarPassosReceita(ref int idReceita) {
            Receita _rec = dao_receita.Get(ref idReceita);

            return _rec.GetPassos();
        }

		/*public Passo ProximoPasso() {
            if (passo < rec.Num_passos())
                passo += 1;

            VerPasso();
		}
    */
		public void VerPasso() {
			throw new System.Exception("Not implemented");
		}

		public void AnteriorPasso() {
            if (passo > 1)
                passo -= 1;

            VerPasso();
		}

		public Planeador CriarPlaneador() {
			throw new System.Exception("Not implemented");
		}
		public Receita[] PesquisarReceita(ref string nome) {
			throw new System.Exception("Not implemented");
		}
		public void ConsultarUtilizador(ref Utilizador user) {
			throw new System.Exception("Not implemented");
		}


	}

}
