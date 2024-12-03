using System;
using AbpSolution1.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AbpSolution1.Books;

public class BookAppService :
    CrudAppService<
        Book, //The Book entity
        BookDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateBookDto>, //Used to create/update a book
    IBookAppService //implement the IBookAppService
{
    public BookAppService(IRepository<Book, Guid> repository)
        : base(repository)
    {
        GetPolicyName = AbpSolution1Permissions.Books.Default;
        GetListPolicyName = AbpSolution1Permissions.Books.Default;
        CreatePolicyName = AbpSolution1Permissions.Books.Create;
        UpdatePolicyName = AbpSolution1Permissions.Books.Edit;
        DeletePolicyName = AbpSolution1Permissions.Books.Delete;
    }
}