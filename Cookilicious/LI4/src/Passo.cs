using System;
namespace Cooklicous {
	public class Passo {
		private int id;
		private string descricao;
		private int duracao;
		private string href;

        public Passo(string descricao, int duracao, string href){
            this.descricao = descricao;
            this.duracao = duracao;
            this.href = href;
        }

        public int GetId() {
			return this.id;
		}
		public void SetId(ref int id) {
			this.id = id;
		}
		public string GetDescricao() {
			return this.descricao;
		}
		public void SetDescricao(ref string descricao) {
			this.descricao = descricao;
		}
		public int GetDuracao() {
			return this.duracao;
		}
		public void SetDuracao(ref int duracao) {
			this.duracao = duracao;
		}
		public void GetAttribute() {
			throw new System.Exception("Not implemented");
		}
		public void SetAttribute(ref object attribute) {
			throw new System.Exception("Not implemented");
		}
		public string GetHref() {
			return this.href;
		}
		public void SetHref(ref string href) {
			this.href = href;
		}


	}

}
