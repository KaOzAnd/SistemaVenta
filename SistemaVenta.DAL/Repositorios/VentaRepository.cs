using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using SistemaVenta.DAL.DBContext;
using SistemaVenta.DAL.Repositorios.Contrato;
using SistemaVenta.Model;

namespace SistemaVenta.DAL.Repositorios
{
    public class VentaRepository :IGenericRepository<Venta>, IVentaRepository
    {
        private readonly DbventaContext _dbcontext;

        public VentaRepository(DbventaContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public Task<IQueryable<Venta>> Consultar(Expression<Func<Venta, bool>> filtro = null)
        {
            throw new NotImplementedException();
        }

        public Task<Venta> Crear(Venta modelo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Editar(Venta modelo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(Venta modelo)
        {
            throw new NotImplementedException();
        }

        public Task<Venta> Obtener(Expression<Func<Venta, bool>> filtro)
        {
            throw new NotImplementedException();
        }

        public Task<Venta> Registrar(Venta modelo)
        {
            throw new NotImplementedException();
        }
    }
}
