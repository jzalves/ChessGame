using tabuleiro;
namespace xadrez
{
    class Rei : Peca
    {
        public Rei (Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }
        public override string ToString()
        {
            return "R";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != this.cor;
         }
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0,0);

            //acima
            pos.definorValores(posicao.Linha - 1, posicao.Coluna);
            if(tab.posicaoValida(pos)&& podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //ne
            pos.definorValores(posicao.Linha -1, posicao.Coluna +1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //direita
            pos.definorValores(posicao.Linha, posicao.Coluna +1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //se
            pos.definorValores(posicao.Linha +1, posicao.Coluna +1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //abaixo
            pos.definorValores(posicao.Linha +1, posicao.Coluna);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //so
            pos.definorValores(posicao.Linha +1, posicao.Coluna -1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //esquerda
            pos.definorValores(posicao.Linha, posicao.Coluna -1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //no
            pos.definorValores(posicao.Linha -1, posicao.Coluna -1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            return mat;
        }
    }
}
