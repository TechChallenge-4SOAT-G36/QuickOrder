﻿using QuickOrder.Core.Domain.ValueObjects;

namespace QuickOrder.Core.Domain.Entities
{
    public class Usuario : EntityBase, IAggregateRoot
    {
        protected Usuario() { }

        public Usuario(string nome, string cpf, string email, bool status, int role)
        {
            Nome = new NomeVo(nome);
            Cpf = new CpfVo(cpf);
            Email = new EmailVo(email);
            Status = status;
            Role = role;
        }

        public Usuario(string nome, string cpf, string email, bool status)
        {
            Nome = new NomeVo(nome);
            Cpf = new CpfVo(cpf);
            Email = new EmailVo(email);
            Status = status;
        }

        public virtual NomeVo Nome { get; private set; }
        public virtual CpfVo Cpf { get; private set; }
        public virtual EmailVo Email { get; private set; }
        public virtual bool Status { get; private set; }
        public virtual int Role { get; set; }
        public virtual List<Cliente> Clientes { get; set; }
        public virtual List<Funcionario> Funcionarios { get; set; }

    }
}
