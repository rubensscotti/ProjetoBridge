namespace ProjetoBridge
{
    public class Renderizador2D : IRenderizador
    {
        public void RenderizarForma(string nome)
        {
            Console.WriteLine($"Renderizando {nome} em 2D");
        }
    }
}
