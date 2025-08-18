using AutoMapper;
using Microsoft.IdentityModel.Tokens.Experimental;
using RedBubble.Application.DTOs.Design;
using RedBubble.Application.Interfaces;
using RedBubble.Domain.Entities.Models;
using RedBubble.Domain.Enums;
using RedBubble.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.Services
{
    public class DesignService : IDesignService
    {

        private readonly IDesignRepository _designRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork; // from infra layer with repositories

        public DesignService(IDesignRepository designRepository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _designRepository = designRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task CreateAsync(ArtistDesignDTO artistDesignDTO , Guid artistId)
        {

            var design = _mapper.Map<Design>(artistDesignDTO);

            design.ArtistId = artistId;
            design.Status = DesignStatus.Pending;
            design.UploadedAt = DateTime.Now;


            await _designRepository.AddAsync(design);
            await _unitOfWork.CompleteAsync();
        }




        public async Task<IEnumerable<ArtistGetDesignDTO>> GetAllAsync(Guid artistId)
        {
            // we need to filter here by artist id 
            //var designs = await _designRepository.GetAllAsync();

            var designs =  _designRepository.GetAllByArtist(artistId);
            

            var designsDTO = _mapper.Map<IEnumerable<ArtistGetDesignDTO>>(designs);

            return designsDTO;
        }

        public async Task Update(ArtistDesignDTO artistDesignDTO , int designId)
        {

            var design = await _designRepository.GetByIdAsync(designId);

            _mapper.Map(artistDesignDTO , design);
         
            _designRepository.Update(design);
            await _unitOfWork.CompleteAsync();

            // _mapper.Map(dto, oldEntity)	=> Updates existing tracked entity	
            // var newEntity = _mapper.Map<Entity>(dto) => Creates a new object	 and  Not suitable for updating existing


        }
        //getbyid service instead of call repo 
        //var oldDesign = await _designRepository.GetByIdAsync(designId);

        //var newDesign = _mapper.Map<Design>(artistDesignDTO);

        //update(artistDesignDTO , designId ) => in controller get design by id in first
        //public async Task<Design> GetByIdAsync(Guid id)
        //{
        //    return await _designRepository.GetByIdAsync(id);
        //}

        //public async Task<Design> GetByNameAsync(string name)
        //{
        //    return await _designRepository.GetByNameAsync(name);
        //}


        //public async Task UpdateAsync(Guid id, Design design)
        //{
        //    var d = await _designRepository.GetByIdAsync(id);

        //    _designRepository.Update(d);

        //    await _unitOfWork.CompleteAsync();

        //}

        //public async Task DeleteAsync(Guid id)
        //{
        //    var d = await _designRepository.GetByIdAsync(id);

        //    _designRepository.Delete(d);

        //    await _unitOfWork.CompleteAsync();
        //}
    }

}

// create for artist 
#region Why SaveChanges or UnitOfWork in Service not Repo ?
//Case: Place an Order
//Let’s say placing an order includes:
//Create an Order
//Create multiple OrderItems
//Update Product inventory (reduce stock)

//If SaveChanges() is in repo:
//Each operation hits DB separately:

//_orderRepo.Add(order);       // DB hit
//_orderItemRepo.Add(item);    // Another DB hit
//_productRepo.Update(product); // Another DB hit
// If OrderItemRepo.SaveChanges() throws, you already saved the order — inconsistent DB.

//If SaveChanges() is in service:

//_orderRepo.Add(order);
//_orderItemRepo.Add(item);
//_productRepo.Update(product);
//_context.SaveChanges(); // or _unitOfWork.SaveChanges();

//Now:
// All changes are committed at once.
// If anything fails, nothing is saved (transaction can roll back).
// Much more robust for business-critical flows.
#endregion

#region use CompleteAsync() or DisposeAsync()?
//CompleteAsync() => To save all changes to DB
//DisposeAsync() => Not needed inside service (handled by DI)
#endregion

//Task<IEnumerable<Design>> GetAllAsync(); // design dto => who gets user or artist or admin ?? i think every one will see the designs with different dto
//Task<Design> GetByIdAsync(Guid id);  // design dto 
//Task<Design> GetByNameAsync(string name); // design dto 

//Task CreateAsync(Design design); // design dto 

//Task DeleteAsync(Guid id);

//Task UpdateAsync(Guid id, Design design);// design dto 
