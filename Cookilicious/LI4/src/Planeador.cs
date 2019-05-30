using System;
namespace Cooklicous {
	public class Planeador {
		private Receita almoco;
		private Receita jantar;
		private Utilizador utilizador;
		private int id;
		private DateTime dia;

		public Receita GetAlmoco() {
			return this.almoco;
		}
		public void SetAlmoco(ref Receita almoco) {
			this.almoco = almoco;
		}
		public Receita GetJantar() {
			return this.jantar;
		}
		public void SetJantar(ref Receita jantar) {
			this.jantar = jantar;
		}
		public Utilizador GetUtilizador() {
			return this.utilizador;
		}
		public void SetUtilizador(ref Utilizador utilizador) {
			this.utilizador = utilizador;
		}
		public int GetId() {
			return this.id;
		}
		public void SetId(ref int id) {
			this.id = id;
		}
		public DateTime GetDia() {
			return this.dia;
		}
		public void SetDia(ref DateTime dia) {
			this.dia = dia;
		}

		private Utilizador[] planeador;

	}

}
