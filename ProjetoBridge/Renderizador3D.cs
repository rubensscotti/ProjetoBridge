namespace ProjetoBridge
{
    public class Renderizador3D : IRenderizador
    {
        public void RenderizarForma(string nome)
        {
            Console.WriteLine($"Renderizando {nome} em 3D");
        }
    }
}
