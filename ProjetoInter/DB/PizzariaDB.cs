﻿using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Storage;
using ProjetoInter.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInter.DB
{
    // DbContext é a classe da biblioteca "EntityFramework Pomelo" responsável por conter os métodos de acesso ao banco de dados
    public class PizzariaDB : DbContext
    {
        // método passando as configurações de conexão com o banco de dados.

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                var stringConexao = "Server=localhost;Database=SuaBasedeDados;User=root;Password=SuaSenha";
                options.UseMySql(stringConexao);
            }
        }

        // informando para o entity que ele terá uma tabela chamada usuários e que a classe usuário dentro de modelos será mapeada para representar a tabela e os campos dentro do banco de dados
        public DbSet<Usuario> Usuarios { get; set; }

    }
}