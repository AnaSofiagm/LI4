using System;
namespace Cooklicous {
	public class Utensilio {
		private int id;
		private string nome;

        public Utensilio(string nome){
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
