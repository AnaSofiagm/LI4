using System;
namespace Cooklicous {
	public class Comentario {
		private int id;
		private string texto;
		private int receita;
		private DateTime data;
        private Utilizador user;

        public Comentario(string texto, int receita, Utilizador user){
            this.texto = texto;
            this.receita = receita;
            this.user = user;
        }

        public int GetId() {
			return this.id;
		}
		public void SetId(ref int id) {
			this.id = id;
		}
		public string GetTexto() {
			return this.texto;
		}
		public void SetTexto(ref string texto) {
			this.texto = texto;
		}
		public int GetReceita() {
			return this.receita;
		}
		public void SetReceita(ref int receita) {
			this.receita = receita;
		}
		public DateTime GetData() {
			return this.data;
		}
		public void SetData(ref DateTime data) {
			this.data = data;
		}

		private UnnamedClass1 -comentarios2;


	}

}
