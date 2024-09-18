namespace ProjetoBridge
{
    public class Circulo : Forma
    {
        public Circulo(IRenderizador renderizador) : base(renderizador) { }

        public override void Desenhar()
        {
            renderizador.RenderizarForma("Círculo");
        }
    }
}
