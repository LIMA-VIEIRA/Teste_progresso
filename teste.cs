namespace Teste_Gft.Teste_progresso
{
    public class funcionario
    {
        public (string name, int matricula, string cpf, double salario);
        {
         public string name;
         public int matricula;
         public string cpf;
         public double salario;
         public override string ToSring(){
             return this.name + " " + this.salario + " " + this.cpf + " "+ this.dataadmissao;
         }
        }

    }
