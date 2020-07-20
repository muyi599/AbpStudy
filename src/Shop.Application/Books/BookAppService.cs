using System;
using Shop.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Shop.Books
{
    public class BookAppService : CrudAppService<Book, BookDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateBookDto>,IBookAppService
    {
        public BookAppService(IRepository<Book, Guid> repository) : base(repository)
        {
            GetPolicyName = ShopPermissions.Books.Default;
            GetListPolicyName = ShopPermissions.Books.Default;
            CreatePolicyName = ShopPermissions.Books.Create;
            UpdatePolicyName = ShopPermissions.Books.Edit;
            DeletePolicyName = ShopPermissions.Books.Delete;
        }
    }
}