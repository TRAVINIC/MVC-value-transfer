using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa_barth
{
    class Conta
    {
        //atributos
        public int Numero { get; set; }

        public string Titular { get; set; }
        public double Saldo { get; set; }


        //metodos

        //verificar saldo
        public string VerSaldo()
        {
            return $"O saldo do correntista: {Titular}, conta numero {Numero} é de: {Saldo.ToString()}";
        }

        //add valor á conta dos correntistas
        /*
         obs. feito de forma correta, podemos ultilizar o padrão com os atributos,basta trocar a variavel valor pelo 
        atributo saldo e o "this" fára sentido
         */
        public void depositar(double Valor)
        {
            //this.Saldo = this.Saldo + Saldo;
            //utilizar operador de atribuiçao
            this.Saldo += Saldo; //atribuir e soma ao atributo
        }
        // Sacar valor dos correntistas
        /*
         somar saldo ao atributo do correntista em depositar, e subtrair em Sacar
         */
        public void Sacar(double Saldo)
        {
            this.Saldo -= Saldo; // o mesmo so q subtraindo
        }

        //g. Transferir o valor R$100,00 do correntista 1 para o correntista 2;

        /*
         utilizar recurso parametro com objeto
        conta = classe e destino = correntista q vai receber o valor

         */
        public void Transferir(double Saldo, Conta destino)
        {
            //primeiro vamos retirar da conta do correntista o valor (objeto) q fara a chamada
            //do método.
            this.Saldo -= Saldo;

            //agr depositar no atributo slado do correntista 2 q esta
            //recebendo o deposito.
            destino.Saldo += Saldo;

        }




    }
}