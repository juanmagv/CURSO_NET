using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejexrcicio_consola_banco
{
    class Cuenta
    { 
        private int numCuenta;
        private string numCliente;
        private double saldo;

        public Cuenta()
        {

        }
        public int PnumCuenta
        {
            set { numCuenta = value; }
            get { return numCuenta; }
        }
        public string PnumCliente
        {
            set { numCliente = value; }
            get { return numCliente; }
        }
        public double Psaldo
        {
            set { saldo = value; }
            get { return saldo; }
        }
        public void consultaDatos()
        {
            Console.WriteLine("Numero de cuenta: " + this.PnumCuenta + "\n Numero de cliente: " + this.PnumCliente + "\n saldo: " + this.Psaldo);
        }

        public void depositar(int deposito)
        {
            this.saldo = this.saldo + deposito;
        }
        public void retirar(int retiro)
        {
            this.saldo = this.saldo -retiro;
        }


    }
}
