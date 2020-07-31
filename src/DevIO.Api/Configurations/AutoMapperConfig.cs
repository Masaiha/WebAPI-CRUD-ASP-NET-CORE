using AutoMapper;
using DevIO.Api.ViewModels;
using DevIO.Business.Models;

namespace DevIO.Api.Extensions
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Fornecedor, FornecedorViewModel>();
            CreateMap<Endereco, EnderecoViewModel>();
            CreateMap<Produto, ProdutoImagemViewModel>();

            CreateMap<FornecedorViewModel, Fornecedor>();
            CreateMap<EnderecoViewModel, Endereco>();
            CreateMap<ProdutoImagemViewModel, Produto>();
        }
    }
}
