using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.Services
{
    public class PagedList<T>
    {
      private PagedList(IEnumerable<T>  items,int page,int pageSize,int totalCount)
        {
            Items = items;
            Page = page;
            PageSize = pageSize;
            TotalCount = totalCount;
            
            
        }
        public IEnumerable<T> Items { get; }
        public int Page { get; }
        public int PageSize {  get; }
        public int TotalCount { get; } = 0;
        
        public bool HasNextPage => Page * PageSize < TotalCount;
        public bool PrevNextPage => Page > 1;
        public static async Task<PagedList<T>> CreateAsync(IQueryable<T> query,int page,int pageSize)
        {
            var totalCount = await query.CountAsync();
            var items = await query.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
            return new PagedList<T>(items, page, pageSize, totalCount);

        }

    }
}
