using System;

namespace ProjetoBridge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Renderizador 2D
            IRenderizador renderizador2D = new Renderizador2D();

            // Renderizador 3D
            IRenderizador renderizador3D = new Renderizador3D();

            // Formas com renderizador 2D
            Forma circulo2D = new Circulo(renderizador2D);
            Forma quadrado2D = new Quadrado(renderizador2D);

            // Formas com renderizador 3D
            Forma circulo3D = new Circulo(renderizador3D);
            Forma quadrado3D = new Quadrado(renderizador3D);

            // Desenhar formas
            circulo2D.Desenhar();
            quadrado2D.Desenhar();
            circulo3D.Desenhar();
            quadrado3D.Desenhar(); 
        }
    }
}
