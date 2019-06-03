using System;
namespace Cooklicous {
	public class Utilizador {
		private string nome;
		private int id;
		private string email;
		private string password;
		private Categoria[] pref_categorias;
		private Utensilio[] pref_utensilios;
		private Ingrediente[] pref_ingredientes;
         private Comentario[] comentarios;
         private Receita[] receitas;

        public Utilizador(string nome, string email, string password){
            this.nome = nome;
            this.email = email;
            this.password = password;
        }

        public string GetNome() {
			return this.nome;
		}
		public void SetNome(ref string nome) {
			this.nome = nome;
		}
		public int GetId() {
			return this.id;
		}
		public void SetId(ref int id) {
			this.id = id;
		}
		public string GetEmail() {
			return this.email;
		}
		public void SetEmail(ref string email) {
			this.email = email;
		}
		public string GetPassword() {
			return this.password;
		}
		public void SetPassword(ref string password) {
			this.password = password;
		}
		public void AddComentario(ref string texto, ref int receita) {
			throw new System.Exception("Not implemented");
		}
		public Receita[] GetReceitas() {
			throw new System.Exception("Not implemented");
		}
		public void SetReceitas(ref Receita[] receitas) {
			throw new System.Exception("Not implemented");
		}
		public void AddReceita(ref Receita rec) {
			throw new System.Exception("Not implemented");
		}
		public Categoria[] GetPref_categorias() {
			return this.pref_categorias;
		}
		public void SetPref_categorias(ref Categoria[] pref_categorias) {
			this.pref_categorias = pref_categorias;
		}
		public Utensilio[] GetPref_utensilios() {
			return this.pref_utensilios;
		}
		public void SetPref_utensilios(ref Utensilio[] pref_utensilios) {
			this.pref_utensilios = pref_utensilios;
		}
		public Ingrediente[] GetPref_ingredientes() {
			return this.pref_ingredientes;
		}
		public void SetPref_ingredientes(ref Ingrediente[] pref_ingredientes) {
			this.pref_ingredientes = pref_ingredientes;
		}

	}

}
