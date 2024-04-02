namespace Facade
{
    public class ScoreClientFacade
    {
        DetranAPI detran = new();
        SerasaAPI serasa = new();
        ReceitaFederalAPI receita = new();

        public double Score(string CPF, string CNH)
        {
            var cnhValid = detran.CNHValid(CNH);
            var scoreSerasa = serasa.Score(CPF);
            var cpfActive = receita.CPFActive(CPF);

            var scoreSerasa20p100 = scoreSerasa * 0.2;
            var scoreSerasa30p100 = scoreSerasa * 0.3;
            var Score = scoreSerasa * 1.0;

            if (!cnhValid)
                Score = (Score - scoreSerasa20p100);

            if (!cpfActive)
                Score = (Score - scoreSerasa30p100);

            return Score;
        }
    }
}
