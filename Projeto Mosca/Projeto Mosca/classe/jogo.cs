namespace Projeto_Mosca.classe
{
    internal class jogo
    {
        // ATRIBUTOS
        private string Titulo;
        private int Ano;
        private string Genero;
        private int Maxjog;
        private int Pontmet;

        // CONSTRUTORES
        public jogo(string Titulo, int Ano, string Genero, int Maxjog, int Pontmet)
        {

            this.Titulo = Titulo;
            this.Ano = Ano;
            this.Genero = Genero;
            this.Maxjog = Maxjog;
            this.Pontmet = Pontmet;
        }
        //METODOS DE ACESSO
        public String getTitulo()
        {
            return this.Titulo;
        }
        public void setTitulo(String Titulo)
        {
            if (Titulo != null)
            {
                this.Titulo = Titulo;
            }
             
        }
         public int getAno()
        {
            return this.Ano;
        }
        public void setAno(int Ano)
        {
            if (Ano != 0)
            {
                this.Ano = Ano;
            }
        }
       
        public String getGenero()
        {
            return this.Genero;
        }
        public void setGenero(String Genero)
        {
            if (Genero != null)
            {
                this.Genero = Genero;
            }

        }
        public int getMaxjog()
        {
            return this.Maxjog;
        }
        public void setMaxjog(int Maxjog) 
        {
            if (Maxjog != 0)
            {
                this.Maxjog = Maxjog;
            }
        }
        public int getPontmet()
        {
            return this.Pontmet;
        }
        public void setPontmet(int Pontmet)
        {
            if (Pontmet != 0)
            {
                this.Pontmet = Pontmet;
            }
        }
    }
}
