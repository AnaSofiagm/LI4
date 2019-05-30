using System;
namespace Cooklicous {
	public class Ingrediente {
		private int id;
		private string nome;
		private int quantidade;

        public Ingrediente(string nome){
            this.nome = nome;
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
		public int GetQuantidade() {
			return this.quantidade;
		}
		public void SetQuantidade(ref int quantidade) {
			this.quantidade = quantidade;
		}


	}

}
