namespace ProjetoBridge
{
    public class Quadrado : Forma
    {
        public Quadrado(IRenderizador renderizador) : base(renderizador) { }

        public override void Desenhar()
        {
            renderizador.RenderizarForma("Quadrado");
        }
    }
}
