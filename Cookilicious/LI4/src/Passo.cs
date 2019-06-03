using System;
namespace Cooklicous {
	public class Passo {
		private int id;
		private string descricao;
		private int duracao;
		private string imagem;
        private string video;

        public Passo(string descricao, int duracao, string imagem, string video){
            this.descricao = descricao;
            this.duracao = duracao;
            this.imagem = imagem;
            this.video = video;
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
		public string GetImagem() {
			return this.imagem;
		}
		public void SetImage(ref string href) {
			this.imagem = href;
		}
        public string GetVideo(){
            return this.video;
        }
        public void SetVideo(ref string href){
            this.video = href;
        }

    }

    }

}
