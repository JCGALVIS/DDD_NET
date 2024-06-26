﻿using Pacagroup.Ecommerce.Domain.Entity;

namespace Pacagroup.Ecommerce.Infraestructura.Interface
{
    public interface ICustomerRepositry
    {
        #region Métodos Síncronos

        bool Insert(Customers customers);
        bool Update(Customers customers);
        bool Delete(string customerId);
        Customers Get(string customerId);
        IEnumerable<Customers> GetAll();

        #endregion

        #region Métodos Asíncronos

        Task<bool> InsertAsync(Customers customers);
        Task<bool> UpdateAsync(Customers customers);
        Task<bool> DeleteAsync(string customerId);
        Task<Customers> GetAsync(string customerId);
        Task<IEnumerable<Customers>> GetAllAsync();

        #endregion
    }
}
