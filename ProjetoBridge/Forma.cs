using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBridge
{
    public abstract class Forma
    {
        protected IRenderizador renderizador;

        public Forma(IRenderizador renderizador)
        {
            this.renderizador = renderizador;
        }

        public abstract void Desenhar();
    }
}
