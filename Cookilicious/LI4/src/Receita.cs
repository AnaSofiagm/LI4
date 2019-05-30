using System;
namespace Cooklicous {
	public class Receita {
		private int id;
		private string nome;
		private int avaliacao;
		private string dificuldade;
		private string info;
		private int tempo;
        private Categoria categoria;
        private Ingrediente[] ingredientes;
        private Passo[] passos;
        private Utensilio[] utensilios;
        private Comentario[] comentarios;

        public Receita(string nome, string dificuldade, string info, Categoria categoria){
            this.nome = nome;
            this.dificuldade = dificuldade;
            this.info = info;
            this.categoria = categoria;
        }

        public int GetId() {
			return this.id;
		}
		public void SetId(ref int id) {
			this.id = id;
		}
		public string GetNome() {
			return this.nome;
		}
		public void SetNome(ref string nome) {
			this.nome = nome;
		}
		public int GetAvaliacao() {
			return this.avaliacao;
		}
		public void SetAvaliacao(ref int avaliacao) {
			this.avaliacao = avaliacao;
		}
		public string GetDificuldade() {
			return this.dificuldade;
		}
		public void SetDificuldade(ref string dificuldade) {
			this.dificuldade = dificuldade;
		}
		public string GetInfo() {
			return this.info;
		}
		public void SetInfo(ref string info) {
			this.info = info;
		}
		public int GetTempo() {
			return this.tempo;
		}
		public void SetTempo(ref int tempo) {
			this.tempo = tempo;
		}
		public Categoria GetCategoria() {
			throw new System.Exception("Not implemented");
		}
		public void SetCategoria(ref Categoria cat) {
			throw new System.Exception("Not implemented");
		}
		public Ingrediente[] GetIngredientes() {
			throw new System.Exception("Not implemented");
		}
		public void SetIngredientes(ref Ingrediente[] ing) {
			throw new System.Exception("Not implemented");
		}
		public void AddIngrediente(ref Ingrediente ing) {
			throw new System.Exception("Not implemented");
		}
		public Passo[] GetPassos() {
			throw new System.Exception("Not implemented");
		}
		public void SetPassos(ref Passo[] passos) {
			throw new System.Exception("Not implemented");
		}
		public Utensilio[] GetUtensilios() {
			throw new System.Exception("Not implemented");
		}
		public void SetUtensilios(ref Utensilio[] utensilios) {
			throw new System.Exception("Not implemented");
		}
		public Comentario[] GetComentarios() {
			throw new System.Exception("Not implemented");
		}
		public void SetComentarios(ref Comentario[] comentarios) {
			throw new System.Exception("Not implemented");
		}
		public void AddPasso(ref Passo passo) {
			throw new System.Exception("Not implemented");
		}
		public void AddUtensilio(ref Utensilio ut) {
			throw new System.Exception("Not implemented");
		}
		public void AddComentario(ref Comentario com) {
			throw new System.Exception("Not implemented");
		}

        public int Num_passos(){
            return this.passos.Length;
        }

    }

}
