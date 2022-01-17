﻿using StudyIO.Business.Models;
using System;
using System.Threading.Tasks;

namespace StudyIO.Business.Interfaces
{
    public interface IFornecedorService
    {
        Task Adicionar(Fornecedor fornecedor);

        Task Atualizar(Fornecedor fornecedor);

        Task Remover(Guid id);

        Task AtualizarEndereco(Endereco endereco);
    }
}