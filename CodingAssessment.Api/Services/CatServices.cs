using AutoMapper;
using CodingAssessment.Api.Data;
using CodingAssessment.Api.Dtos;
using CodingAssessment.Api.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using Transactions.Data;

namespace CodingAssessment.Api.Services
{
    public interface ICatServices
    {
        Task<AppResponse<CatDto>> AddCat(CatDto catDto);
    }
    public class CatServices : ICatServices
    {
        public IApplicationDbContext _dbContext { get; }
        public IMapper _mapper { get; set; }
        public IApplicationWriteDbConnection _writeDbConnection { get; }
        public CatServices(IApplicationDbContext dbContext, IApplicationWriteDbConnection writeDbConnection, IMapper mapper)
        {
            _dbContext = dbContext;
            _writeDbConnection = writeDbConnection;
            _mapper = mapper;
        }
        public async Task<AppResponse<CatDto>> AddCat(CatDto catDto)
        {
            _dbContext.Connection.Open();
            using (var transaction = _dbContext.Connection.BeginTransaction())
            {
                try
                {
                    _dbContext.Database.UseTransaction(transaction as DbTransaction);
                    //Check if cat already exist
                    bool DepartmentExists = await _dbContext.Cats.AnyAsync(a => a.name == catDto.name);
                    if (DepartmentExists)
                    {
                        throw new Exception("Cat Already Exists");
                    }
                    //Add new cat
                    Cat catToInsert = _mapper.Map<Cat>(catDto);
                    catToInsert.Id = Guid.NewGuid().ToString();
                    _dbContext.Cats.Add(catToInsert);
                    var catSaveResult = await  _dbContext.SaveChangesAsync(default);
                    if(catSaveResult == 0)
                    {
                        throw new Exception("Failed to save cat Data");
                    }

                    var catImageTInsert = catToInsert.Image;
                    catImageTInsert.Id = Guid.NewGuid().ToString();
                    _dbContext.Images.Add(catImageTInsert);
                    var imageSaveResult = await _dbContext.SaveChangesAsync(default);

                    var catWeightTInsert = catToInsert.Weight;
                    catImageTInsert.Id = Guid.NewGuid().ToString();
                    _dbContext.Weights.Add(catWeightTInsert);
                    var  weightSaveResult = await _dbContext.SaveChangesAsync(default);


                    //add cat weight & images
                    //Commmit
                    transaction.Commit();
                    //Return new CatDto

                    var CatDtoToReturn = _mapper.Map<CatDto>(catToInsert);
                    return new AppResponse<CatDto> { IsSucessful = true ,Payload = CatDtoToReturn ,ResponseCode = System.Net.HttpStatusCode.OK,
                    ResponseMessage = "Insert opertaion sucesssful"};
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception (ex.Message);
                }
                finally
                {
                    _dbContext.Connection.Close();
                }
            }
        }
    }
}
