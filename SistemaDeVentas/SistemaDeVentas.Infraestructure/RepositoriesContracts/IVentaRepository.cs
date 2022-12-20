﻿using SistemaDeVentas.DomainEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.Infraestructure.RepositoriesContracts
{
    public interface IVentaRepository
    {
        Task<ICollection<Venta>> GetAllAsync();

        Task<Venta> GetIdAsync(int id);

        Task AddAsync(Venta obj);
    }
}
