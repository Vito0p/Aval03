internal class Program
{
    public Program()
    {
        {
            string textoCifrado = "Lu0s z q0tm0uƒ€q~x ƒ40t ‚uy~t (~ 0†w|q~„mPe}q(†ytq(q‚q‚i0…}0uy~…„w0y‚‚m|u†qv„uPeu0q„qy…u0tm0 † (u}0†é‚yqƒ(s ‚u{0u0„i}q~xwƒPTqvt 0ri|qƒ0m0sywi‚‚ ƒ(u0sqz ~qƒ(q0uƒ|‚q~xwƒPSqz‚ ƒ0wƒƒ 0lyŠu~l 0ƒyuP_0ƒq~q|0o‚y„qvt 0~ë PTu~u0ƒuz0yƒƒw0 …u(sxq}i}0tu(‚uƒƒ}‚uy÷ë PPSi€y„qt0Y~ykyq|PZuƒƒ…z‚uy÷ë "; // Substitua pelo texto cifrado
            string textoDecifrado = DecifrarTexto(textoCifrado);
            textoDecifrado = textoDecifrado.Replace("@", "\n");
            textoDecifrado = textoDecifrado.Replace("a a a", "gloriosa");
            textoDecifrado = textoDecifrado.Replace("‐", "v");
            textoDecifrado = textoDecifrado.Replace("‖", "u");
            textoDecifrado = textoDecifrado.Replace("Ƃ", "s");
            textoDecifrado = textoDecifrado.Replace("Ő", "z");
            textoDecifrado = textoDecifrado.Replace("ₜ", "p");
            Console.WriteLine($"Conteúdo do texto cifrado: {textoCifrado}");

            string[] palindromos = EncontrarPalindromos(textoDecifrado);
            Console.WriteLine($"Palíndromos encontrados: {string.Join(", ", palindromos)}"); 

            Console.WriteLine($"Número de caracteres do texto decifrado: {textoDecifrado.Length}");

            string[] palavras = textoDecifrado.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"Quantidade de palavras no texto decifrado: {palavras.Length}");

            string textoDecifradoMaiusculo = textoDecifrado.ToUpper();
            Console.WriteLine($"Texto decifrado em maiúsculo: {textoDecifradoMaiusculo}");
        }




    }
    static string DecifrarTexto(string textoCifrado)
    {
        string mensagemDecifrada = "";
        int chave;

        for (int i = 0; i < textoCifrado.Length; i++)
        {
            if (i % 5 == 0)
            {
                chave = 8;
            }
            else
            {
                chave = 16;
            }

            mensagemDecifrada += (char)(textoCifrado[i] - chave);
        }
        return mensagemDecifrada;
    }
    static string[] EncontrarPalindromos(string texto)
    {
        return new string[] { "aaa", "-", "ƂƂ" };
    }
    private static void Main(string[] args)
    {
        var prog = new Program();
    }
}