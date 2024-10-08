﻿using Microsoft.EntityFrameworkCore;
using SistemaAgendamentoTarefas.Entities;

namespace SistemaAgendamentoTarefas.Context
{
    public class OrganizadorContext : DbContext
    {
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options)
        {

        }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}
