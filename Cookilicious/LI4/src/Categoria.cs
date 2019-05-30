using System;
namespace Cooklicous {
	public class Categoria {
		private int id;
		private string nome;

        public Categoria(string nome){
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


	}

}
