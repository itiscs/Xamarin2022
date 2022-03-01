using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App1.Models
{
    public class ProductsRepository
    {
        SQLiteAsyncConnection database;
        public ProductsRepository(string databasePath)
        {
            database = new SQLiteAsyncConnection(databasePath);
        }
        public async Task CreateTable()
        {
            await database.CreateTableAsync<Product>();
        }
        public async Task<List<Product>> GetItemsAsync()
        {
            return await database.Table<Product>().ToListAsync();

        }
        public async Task<Product> GetItemAsync(int id)
        {
            return await database.GetAsync<Product>(id);
        }
        public async Task<int> DeleteItemAsync(Product item)
        {
            return await database.DeleteAsync(item);
        }
        public async Task<int> SaveItemAsync(Product item)
        {
            if (item.Id != 0)
            {
                await database.UpdateAsync(item);
                return item.Id;
            }
            else
            {
                return await database.InsertAsync(item);
            }
        }
    }
}
