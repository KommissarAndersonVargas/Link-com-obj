using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

     class Worker
    {

    public string nome { get; set; }
    public double salario{ get; set; }

    public Worker(string nome, double salario)
    {
        this.nome = nome;
        this.salario = salario;
    }

    public override string ToString()
    {
        return "Nome: " + nome + " Salario: " + salario;
    }
}

